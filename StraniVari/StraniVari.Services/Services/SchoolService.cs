using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly StraniVariDbContext _context;

        public SchoolService(StraniVariDbContext context)
        {
            _context = context;
        }

        public async Task AddSchoolAsync(SchoolUpsertRequest addSchoolRequest)
        {
            var newSchool = new School
            {
                Name = addSchoolRequest.Name,
                Address = addSchoolRequest.Address,
                City = addSchoolRequest.City
            };


            await _context.Schools.AddAsync(newSchool);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteSchoolAsync(int id)
        {
            var school = await _context.Schools.FirstOrDefaultAsync(x => x.Id == id);

            if (school == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _context.Schools.Remove(school);
            await _context.SaveChangesAsync();
        }

        public async Task<GetSchoolDetailsResponse> GetSchoolDetailsAsync(int id)
        {
            var schoolDetails = await _context.Schools
                .Select(x => new GetSchoolDetailsResponse
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address=x.Address, 
                    City = x.City

                }).FirstOrDefaultAsync(x=>x.Id==id);

            return schoolDetails;
        }

        public async Task<List<GetSchoolDetailsResponse>> SchoolListAsync()
        {
            var schoolList = await _context.Schools
               .Select(x => new GetSchoolDetailsResponse
               {
                   Id=x.Id,
                   Name= x.Name,
                   Address = x.Address,
                   City = x.City

               }).ToListAsync();

            return schoolList;
        }

        public async Task UpdateSchoolAsync(int id, SchoolUpsertRequest updateSchoolRequest)
        {
            if (updateSchoolRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var schoolFound = await _context.Schools.FirstOrDefaultAsync(x => x.Id == id);

            if (schoolFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            schoolFound.Name = updateSchoolRequest.Name;
            schoolFound.Address = updateSchoolRequest.Address;
            schoolFound.City = updateSchoolRequest.City;

            _context.Schools.Update(schoolFound);
            await _context.SaveChangesAsync();

        }
    }
}
