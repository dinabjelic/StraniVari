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

        public async Task AddMaterialToSchoolAsync(MaterialSchoolUpSertRequest addMaterialToSchoolRequest)
        {
            var schoolFound = await _straniVariDbContext.Schools.FirstOrDefaultAsync(x => x.Id == addMaterialToSchoolRequest.SchoolId);

            if (schoolFound == null)
            {
                throw new ArgumentException("Invalid request");
            }

            foreach (var item in addMaterialToSchoolRequest.Materials)
            {
                await _straniVariDbContext.SchoolMaterials.AddAsync(new SchoolMaterial
                {
                    SchoolId = schoolFound.Id,
                    Quantity = addMaterialToSchoolRequest.Quantity,
                    MaterialId = item.MaterialId,
                    VolunteeringYear = addMaterialToSchoolRequest.VolunteeringYear
                });
            }
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetMaterialSchoolDetailsResponse>> MaterialSchoolListAsync()
        {

            var materialSchoolList = await _straniVariDbContext
                .SchoolMaterials
                .Select(x => new GetMaterialSchoolDetailsResponse
                {
                    MaterialName = x.Materials.Name,
                    SchoolName = x.Schools.Name,
                    SchoolAdress = x.Schools.Address,
                    SchoolCity = x.Schools.City, 
                    VolunteeringYear =x.VolunteeringYear
                }).ToListAsync();

            return materialSchoolList;
        }

        public async Task RemoveMaterialFromSchoolAsync(MaterialSchoolDeleteRequest materialSchoolDeleteRequest)
        {
            var materialFound = _straniVariDbContext.SchoolMaterials
                .Where(x => x.VolunteeringYear == materialSchoolDeleteRequest.VolunteeringYear &&
                x.SchoolId == materialSchoolDeleteRequest.SchoolId &&
                x.MaterialId == materialSchoolDeleteRequest.MaterialId);

            if (materialFound == null)
            {
                throw new ArgumentException("Invalid request");
            }

            foreach (var item in materialFound)
            {
                _straniVariDbContext.SchoolMaterials.Remove(item);
            }

            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
