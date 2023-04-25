using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class SchoolService : BaseCrudService<School>, ISchoolService 
    {
        public SchoolService(StraniVariDbContext dbContext): base(dbContext) {}

        public async Task<GetSchoolDetailsResponse> GetSchoolDetailsAsync(int id)
        {
            var schoolFound = await GetByIdAsync(id);

            if (schoolFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            var schoolDetails = new GetSchoolDetailsResponse
            {
                Id = schoolFound.Id,
                Name = schoolFound.Name,
                Address = schoolFound.Address,
                City = schoolFound.City
            };

            return schoolDetails;
        }

        public async Task<List<GetSchoolDetailsResponse>> SchoolListAsync()
        {
            var schools = await GetAllAsync();
            var schoolList = schools.Select(x => new GetSchoolDetailsResponse
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                City = x.City
            }).ToList();

            return schoolList;
        }

        public async Task Insert(SchoolUpsertRequest request)
        {
            var newSchool = new School
            {
                Name = request.Name,
                Address = request.Address,
                City = request.City
            };

            await CreateAsync(newSchool);
        }

        public async Task Update(int id, SchoolUpsertRequest request)
        {
            if (request == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var schoolFound = await GetByIdAsync(id);

            if (schoolFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            schoolFound.Name = request.Name;
            schoolFound.Address = request.Address;
            schoolFound.City = request.City;

            await UpdateAsync(schoolFound);
        }

        public async Task Delete(int id)
        {
            await DeleteAsync(id);
        }

        public async Task<List<School>> GetAll()
        {
            var schools = await GetAllAsync();
            var schoolList = schools.Select(x => new School
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                City = x.City
            }).ToList();

            return schoolList;
        }

        public async Task<School> GetById(int id)
        {
            var schoolFound = await GetByIdAsync(id);

            if (schoolFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            var schoolDetails = new School
            {
                Id = schoolFound.Id,
                Name = schoolFound.Name,
                Address = schoolFound.Address,
                City = schoolFound.City
            };

            return schoolDetails;
        }
    }
}
