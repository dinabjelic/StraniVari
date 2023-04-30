using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class MaterialsController : BaseCRUDController<Material, MaterialUpsertRequest, GetMaterialDetailsResponse>
    {
        public MaterialsController(IMaterialService materialService):base(materialService)
        {
        }
    }
}
