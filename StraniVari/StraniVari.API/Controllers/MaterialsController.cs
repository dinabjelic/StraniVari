using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class MaterialsController : BaseCRUDController<Material, MaterialUpsertRequest, MaterialUpsertRequest,GetMaterialDetailsResponse>
    {
        private readonly IMaterialService _materialService;
        public MaterialsController(IMaterialService materialService):base(materialService)
        {
            _materialService = materialService;
        }

        [HttpGet("filtered-data")]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> GetFilteredEvents(string? searchTerm)
        {
            return Ok(await _materialService.GetFilteredMaterials(searchTerm));
        }
    }
}
