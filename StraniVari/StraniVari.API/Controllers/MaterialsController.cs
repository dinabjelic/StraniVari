using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class MaterialsController : BaseApiController
    {
        private readonly IMaterialService _materialService;

        public MaterialsController(IMaterialService materialService)
        {
            _materialService = materialService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMaterials()
        {
            return Ok(await _materialService.GetMaterialsAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddMaterial(MaterialUpsertRequest addMaterialRequest)
        {
            await _materialService.AddMaterialAsync(addMaterialRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMaterial(int id, [FromBody]MaterialUpsertRequest updateMaterialRequest)
        {
            await _materialService.UpdatedMaterialAsync(id, updateMaterialRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMaterial(int id)
        {
            await _materialService.DeleteMaterialAsync(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }
    }
}
