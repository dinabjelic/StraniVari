using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class MaterialService:IMaterialService
    {
        private readonly StraniVariDbContext _straniVariDbContext;

        public MaterialService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task AddMaterialAsync(MaterialUpsertRequest addMaterialRequest)
        {
            var newMaterial = new Material
            {
                Name = addMaterialRequest.Name
            };

            await _straniVariDbContext.Materials.AddAsync(newMaterial);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task DeleteMaterialAsync(int id)
        {
            var material = await _straniVariDbContext.Materials.FirstOrDefaultAsync(x => x.Id == id);

            if (material == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _straniVariDbContext.Materials.Remove(material);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetMaterialDetailsResponse>> GetMaterialsAsync()
        {
            var materialList = await _straniVariDbContext.Materials.Select(x => new GetMaterialDetailsResponse
            {
                Id= x.Id,
                Name = x.Name
            }).ToListAsync();

            return materialList;
        }

        public async Task UpdatedMaterialAsync(int id, MaterialUpsertRequest updateMaterialRequest)
        {
            if (updateMaterialRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var materialFound = await _straniVariDbContext.Materials.FirstOrDefaultAsync(x => x.Id == id);
            
            if(materialFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            materialFound.Name = updateMaterialRequest.Name;

            _straniVariDbContext.Materials.Update(materialFound);
            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
