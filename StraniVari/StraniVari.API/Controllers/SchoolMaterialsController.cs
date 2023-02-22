using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Common.Helper;
using StraniVari.Core.Entities;
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
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> AddMaterialToSchool(InsertMaterialToSchoolRequest insertMaterialToSchoolRequest)
        {
            await _materialSchoolService.AddMaterialToSchoolAsync(insertMaterialToSchoolRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpGet]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> MaterialForSchool(int id)
        {
            return Ok(await _materialSchoolService.MaterialForSchoolAsync(id));
        }

        [HttpPut]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> UpdateMaterialForSchool(UpdateMaterialToSchoolRequest updateMaterialToSchoolRequest)
        {
            await _materialSchoolService.UpdateMaterialForSchoolAsync(updateMaterialToSchoolRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpDelete]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> DeleteMaterialForSchool(int id)
        {
            await _materialSchoolService.DeleteMaterialForSchoolAsync(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpGet("{eventSchoolId}/recommend")]
        [AllowAnonymous]
        public List<SchoolMaterial> RecommendSystem(int eventSchoolId)
        {
            return _materialSchoolService.Recommend(eventSchoolId);
        }

    }
}
