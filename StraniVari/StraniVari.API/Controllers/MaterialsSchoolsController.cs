using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Requests;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class MaterialsSchoolsController : BaseApiController
    {
        private readonly IMaterialSchoolService _materialSchoolService;
        public MaterialsSchoolsController(IMaterialSchoolService materialSchoolService)
        {
            _materialSchoolService = materialSchoolService;
        }

        [HttpGet]
        public async Task<IActionResult> MaterialSchoolList()
        {
            return Ok(await _materialSchoolService.MaterialSchoolListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddMaterialToSchool(MaterialSchoolUpSertRequest addMaterialToSchoolRequest)
        {
            await _materialSchoolService.AddMaterialToSchoolAsync(addMaterialToSchoolRequest);
            return Ok("You succeeded");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveMaterialFromSchool(MaterialSchoolDeleteRequest materialSchoolDeleteRequest)
        {
            await _materialSchoolService.RemoveMaterialFromSchoolAsync(materialSchoolDeleteRequest);
            return Ok("You succeeded");
        }
    }
}
