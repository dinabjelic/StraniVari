using AutoMapper;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class MaterialService: BaseCrudService<Material, MaterialUpsertRequest, GetMaterialDetailsResponse>, IMaterialService
    {
        public MaterialService(StraniVariDbContext straniVariDbContext,IMapper mapper) : base(straniVariDbContext, mapper)
        {
        }
    }
}
