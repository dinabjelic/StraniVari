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
    public class MaterialSchoolService : BaseCrudService<SchoolMaterial, UpdateMaterialToSchoolRequest, GetMaterialsForSchoolRequest>, IMaterialSchoolService
    {
        static MLContext mlContext = null;
        private readonly StraniVariDbContext _straniVariDbContext;
        public MaterialSchoolService(StraniVariDbContext straniVariDbContext, IMapper mapper) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }
        public async Task AddMaterialToSchoolAsync(InsertMaterialToSchoolRequest insertMaterialToSchoolRequest)
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

        //public async Task DeleteMaterialForSchoolAsync(int id)
        //{
        //    var materialFound = await _straniVariDbContext.SchoolMaterials.FirstOrDefaultAsync(x => x.Id == id);

        //    if (materialFound == null)
        //    {
        //        throw new ArgumentException("Invalid id");
        //    }

        //    _straniVariDbContext.SchoolMaterials.Remove(materialFound);
        //    await _straniVariDbContext.SaveChangesAsync();
        //}

        //public async Task<List<GetMaterialsForSchoolRequest>> MaterialForSchoolAsync(int id)
        //{
        //    var schoolMaterialList = await _straniVariDbContext.SchoolMaterials
        //        .Where(x => x.EventSchoolId == id)
        //        .Select(x => new GetMaterialsForSchoolRequest
        //        {
        //            MaterialId = x.MaterialId,
        //            SchoolMaterialId = x.Id,
        //            MaterialName = x.Material.Name,
        //            Quantity = x.Quantity
        //        }).ToListAsync();

        //    return schoolMaterialList;
        //}
        //public async Task UpdateMaterialForSchoolAsync(UpdateMaterialToSchoolRequest updateMaterialToSchoolRequest)
        //{
        //    if (updateMaterialToSchoolRequest == null)
        //    {
        //        throw new ArgumentException("Invalid request");
        //    }

        //    var schoolMaterialFound = await _straniVariDbContext.SchoolMaterials.FirstOrDefaultAsync(x => x.Id == updateMaterialToSchoolRequest.SchoolMaterialId);

        //    if (schoolMaterialFound == null)
        //    {
        //        throw new ArgumentException("Invalid id");
        //    }

        //    schoolMaterialFound.Quantity = updateMaterialToSchoolRequest.Quantity;

        //    _straniVariDbContext.SchoolMaterials.Update(schoolMaterialFound);
        //    await _straniVariDbContext.SaveChangesAsync();
        //}
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

                var data = new List<ProductEntry>();
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
                                data.Add(new ProductEntry()
                                {
                                    MaterialID = (uint)y,
                                    CoPurchaseProductID = (uint)z.MaterialId
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
                options.MatrixColumnIndexColumnName = nameof(ProductEntry.MaterialID);
                options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
                options.LabelColumnName = "Label";
                options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                options.Alpha = 0.01;
                options.Lambda = 0.025;
                options.C = 0.00001;

                var trainer = mlContext.Recommendation().Trainers.MatrixFactorization(options);
                model = trainer.Fit(trainData);
            }

            var elements = _straniVariDbContext.SchoolMaterials.Where(x=>x.EventSchoolId != eventSchoolId).ToList();
            var allItems = elements.GroupBy(x => x.MaterialId).Select(y => y.First()).ToList();

            if(model == null)
            {
                return Enumerable.Empty<SchoolMaterial>().ToList();
            }

            var predictionResult = new List<Tuple<StraniVari.Core.Entities.SchoolMaterial, float>>();

            foreach (var item in allItems)
            {
                var predictionEngine = mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);
                var prediction = predictionEngine.Predict(new ProductEntry()
                {
                    CoPurchaseProductID = (uint)item.MaterialId
                });

                predictionResult.Add(new Tuple<StraniVari.Core.Entities.SchoolMaterial, float>(item, prediction.Score));
            }
            var finalResult = predictionResult.OrderByDescending(x => x.Item2)
               .Select(x => x.Item1).Take(3).ToList();

            return finalResult;
        }
    } 
}
