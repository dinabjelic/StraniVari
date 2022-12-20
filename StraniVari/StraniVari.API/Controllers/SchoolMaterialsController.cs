using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolMaterialsController : BaseApiController
    {
        private readonly IMaterialSchoolService _materialSchoolService;
        public SchoolMaterialsController(IMaterialSchoolService materialSchoolService)
        {
            _materialSchoolService = materialSchoolService;
        }

        [HttpPost]
        public async Task<IActionResult> AddMaterialToSchool(InsertMaterialToSchoolRequest insertMaterialToSchoolRequest)
        {
            await _materialSchoolService.AddMaterialToSchoolAsync(insertMaterialToSchoolRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpGet]
        public async Task<IActionResult> MaterialForSchool(int id)
        {
            return Ok(await _materialSchoolService.MaterialForSchoolAsync(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMaterialForSchool(UpdateMaterialToSchoolRequest updateMaterialToSchoolRequest)
        {
            await _materialSchoolService.UpdateMaterialForSchoolAsync(updateMaterialToSchoolRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMaterialForSchool(int id)
        {
            await _materialSchoolService.DeleteMaterialForSchoolAsync(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

    }
}
