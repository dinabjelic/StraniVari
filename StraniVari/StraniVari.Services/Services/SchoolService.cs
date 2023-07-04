using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class SchoolService : BaseCrudService<School, SchoolUpsertRequest,SchoolUpsertRequest, GetSchoolDetailsResponse>, ISchoolService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public SchoolService(StraniVariDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _straniVariDbContext = dbContext;
        }

        public async Task<List<GetSchoolDetailsResponse>> GetFilteredSchools(string searchTerm)
        {
            var filteredData = await _straniVariDbContext.Schools.Select(x=> new GetSchoolDetailsResponse
            {
                Id = x.Id, 
                Address = x.Address, 
                City = x.City, 
                Name = x.Name
            }).ToListAsync();

            if(!string.IsNullOrWhiteSpace(searchTerm))
            {
                filteredData = filteredData.Where(x => (x.Name + " " + x.Address + " " + x.City).ToLower().Contains(searchTerm.ToLower())).ToList();
            }
            return filteredData;
        }
    }
}
