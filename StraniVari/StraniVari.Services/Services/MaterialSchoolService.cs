using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class MaterialSchoolService : IMaterialSchoolService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public MaterialSchoolService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
        }
        public async Task AddMaterialToSchoolAsync(InsertMaterialToSchoolRequest insertMaterialToSchoolRequest)
        {
            foreach(var item in insertMaterialToSchoolRequest.Materials)
            {
                await _straniVariDbContext.SchoolMaterials.AddAsync(new SchoolMaterial
                {
                    EventSchoolId = insertMaterialToSchoolRequest.EventSchoolId,
                    MaterialId = item
                });
            }

            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task DeleteMaterialForSchoolAsync(int id)
        {
            var materialFound = await _straniVariDbContext.SchoolMaterials.FirstOrDefaultAsync(x => x.Id == id);

            if (materialFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _straniVariDbContext.SchoolMaterials.Remove(materialFound);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetMaterialsForSchoolRequest>> MaterialForSchoolAsync(int id)
        {
            var schoolMaterialList = await _straniVariDbContext.SchoolMaterials
                .Where(x => x.EventSchoolId == id)
                .Select(x => new GetMaterialsForSchoolRequest
                {
                    SchoolMaterialId = x.Id, 
                    MaterialName = x.Material.Name,
                    Quantity = x.Quantity
                }).ToListAsync();

            return schoolMaterialList;
        }

        public async Task UpdateMaterialForSchoolAsync(UpdateMaterialToSchoolRequest updateMaterialToSchoolRequest)
        {
            if (updateMaterialToSchoolRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var schoolMaterialFound = await _straniVariDbContext.SchoolMaterials.FirstOrDefaultAsync(x => x.Id == updateMaterialToSchoolRequest.SchoolMaterialId);

            if (schoolMaterialFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            schoolMaterialFound.Quantity = updateMaterialToSchoolRequest.Quantity;

            _straniVariDbContext.SchoolMaterials.Update(schoolMaterialFound);
            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
