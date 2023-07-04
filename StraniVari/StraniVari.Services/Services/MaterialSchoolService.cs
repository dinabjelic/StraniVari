using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using StraniVari.Core.Entities;
using StraniVari.Core.ML;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class MaterialSchoolService : BaseCrudService<SchoolMaterial, InsertMaterialToSchoolRequest, UpdateMaterialToSchoolRequest, GetMaterialsForSchoolRequest>, IMaterialSchoolService
    {
        static MLContext mlContext = null;
        private readonly StraniVariDbContext _straniVariDbContext;
        public MaterialSchoolService(StraniVariDbContext straniVariDbContext, IMapper mapper) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }
        public override async Task Insert(InsertMaterialToSchoolRequest insertMaterialToSchoolRequest)
        {
            foreach (var item in insertMaterialToSchoolRequest.Materials)
            {
                await _straniVariDbContext.SchoolMaterials.AddAsync(new SchoolMaterial
                {
                    EventSchoolId = insertMaterialToSchoolRequest.EventSchoolId,
                    MaterialId = item
                });
            }

            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetMaterialsForSchoolRequest>> GetMaterialsForSchool(int id)
        {
            var schoolMaterialList = await _straniVariDbContext.SchoolMaterials
                .Where(x => x.EventSchoolId == id)
                .Select(x => new GetMaterialsForSchoolRequest
                {
                    MaterialId = x.MaterialId,
                    SchoolMaterialId = x.Id,
                    MaterialName = x.Material.Name,
                    Quantity = x.Quantity
                }).ToListAsync();

            return schoolMaterialList;
        }

        static ITransformer model = null;
        public List<SchoolMaterial> Recommend(int eventSchoolId)
        {
            if (mlContext == null)
            {
                mlContext = new MLContext();

                var tmpData = _straniVariDbContext.SchoolMaterials.Include(x => x.Material).Include(x => x.EventSchool)
                   .GroupBy(x => x.EventSchoolId)
                   .Select(x => x.Select(y => new EventSchoolMaterial
                   {
                       EventSchoolId = y.EventSchoolId,
                       MaterialId = y.MaterialId,
                       MaterialName = y.Material.Name
                   })).ToList();

                var data = new List<MaterialEntry>();
                foreach (var item in tmpData)
                {
                    if (item.Count() > 1)
                    {

                        var distinctItemId = item.Select(y => y.MaterialId).ToList();

                        distinctItemId.ForEach(y =>
                        {
                            var relatedItems = item.Where(z => z.MaterialId != y).ToList();

                            relatedItems.ForEach(z =>
                            {
                                data.Add(new MaterialEntry()
                                {
                                    MaterialID = (uint)y,
                                    MaterialIDRelated = (uint)z.MaterialId
                                });
                            });
                        });
                    }

                }

                if (!data.Any())
                {
                    return Enumerable.Empty<SchoolMaterial>().ToList();
                }

                var trainData = mlContext.Data.LoadFromEnumerable(data);

                //STEP 3: Your data is already encoded so all you need to do is specify options for MatrxiFactorizationTrainer with a few extra hyperparameters
                //        LossFunction, Alpa, Lambda and a few others like K and C as shown below and call the trainer.
                MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                options.MatrixColumnIndexColumnName = nameof(MaterialEntry.MaterialID);
                options.MatrixRowIndexColumnName = nameof(MaterialEntry.MaterialIDRelated);
                options.LabelColumnName = "Label";
                options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                options.Alpha = 0.01;
                options.Lambda = 0.025;
                options.C = 0.00001;

                var trainer = mlContext.Recommendation().Trainers.MatrixFactorization(options);
                model = trainer.Fit(trainData);
            }

            var elements = _straniVariDbContext.SchoolMaterials.Where(x => x.EventSchoolId != eventSchoolId).ToList();
            var allItems = elements.GroupBy(x => x.MaterialId).Select(y => y.First()).ToList();

            if (model == null)
            {
                return Enumerable.Empty<SchoolMaterial>().ToList();
            }

            var predictionResult = new List<Tuple<StraniVari.Core.Entities.SchoolMaterial, float>>();

            foreach (var item in allItems)
            {
                var predictionEngine = mlContext.Model.CreatePredictionEngine<MaterialEntry, Materialprediction>(model);
                var prediction = predictionEngine.Predict(new MaterialEntry()
                {
                    MaterialID = (uint)eventSchoolId,
                    MaterialIDRelated = (uint)item.MaterialId
                });

                predictionResult.Add(new Tuple<StraniVari.Core.Entities.SchoolMaterial, float>(item, prediction.Score));
            }
            var finalResult = predictionResult.OrderByDescending(x => x.Item2)
               .Select(x => x.Item1).Take(3).ToList();

            return finalResult;
        }

        public async Task<List<GetMaterialsForSchoolRequest>> GetAvailableMaterial(int id)
        {

            var availableMaterial = await _straniVariDbContext.Materials
                .Where(x => !_straniVariDbContext.SchoolMaterials.Any(y => y.MaterialId == x.Id && y.EventSchoolId == id))
                .Select(e => new GetMaterialsForSchoolRequest
                {
                    MaterialId = e.Id,
                    MaterialName = e.Name,
                }).ToListAsync();

            return availableMaterial;
        }

        public async Task<List<GetMaterialResponse>> GetEventSchoolsMaterial(int id)
        {
            var materialsList = await _straniVariDbContext.SchoolMaterials
                 .Where(x => x.EventSchoolId == id)
                 .Select(e => new GetMaterialResponse
                 {
                     Id = e.Id,
                     Name = e.Material.Name,
                     NumberOfMaterial = e.Quantity, 
                     IsChecked = true
                 })
                 .ToListAsync();

            var availableMaterials = await _straniVariDbContext.Materials
                .Where(x => !_straniVariDbContext.SchoolMaterials.Any(y => y.MaterialId == x.Id && y.EventSchoolId == id))
                .Select(e => new GetMaterialResponse
                {
                    Id = e.Id,
                    Name = e.Name,
                    NumberOfMaterial = 0 
                })
                .ToListAsync();

           return materialsList.Concat(availableMaterials).ToList();
        }
    }
}
