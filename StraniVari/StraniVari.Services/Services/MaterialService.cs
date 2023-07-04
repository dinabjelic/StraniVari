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
    public class MaterialService: BaseCrudService<Material, MaterialUpsertRequest, MaterialUpsertRequest,GetMaterialDetailsResponse>, IMaterialService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public MaterialService(StraniVariDbContext straniVariDbContext,IMapper mapper) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task<List<GetMaterialDetailsResponse>> GetFilteredMaterials(string searchTerm)
        {
            var filteredData = await _straniVariDbContext.Materials.Select(x=> new GetMaterialDetailsResponse
            {
                Id = x.Id, 
                Name = x.Name
            }).ToListAsync();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                filteredData = filteredData.Where(x => (x.Name ).ToLower().Contains(searchTerm.ToLower())).ToList();
            }

            return filteredData;
        }
    }
}
