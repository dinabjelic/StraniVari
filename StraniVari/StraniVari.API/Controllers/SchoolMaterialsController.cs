using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolMaterialsController : BaseCRUDController<SchoolMaterial, UpdateMaterialToSchoolRequest, GetMaterialsForSchoolRequest>
    {
        private readonly IMaterialSchoolService _materialSchoolService;
        public SchoolMaterialsController(IMaterialSchoolService materialSchoolService):base(materialSchoolService)
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

        [HttpGet("{eventSchoolId}/recommend")]
        [Authorize(Roles = Role.Administrator)]
        public IActionResult RecommendSystem(int eventSchoolId)
        {
            return Ok(_materialSchoolService.Recommend(eventSchoolId));
        }
        //[HttpGet]
        //[Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        //public async Task<IActionResult> MaterialForSchool(int id)
        //{
        //    return Ok(await _materialSchoolService.MaterialForSchoolAsync(id));
        //}

        //[HttpPut]
        //[Authorize(Roles = Role.Administrator)]
        //public async Task<IActionResult> UpdateMaterialForSchool(UpdateMaterialToSchoolRequest updateMaterialToSchoolRequest)
        //{
        //    await _materialSchoolService.UpdateMaterialForSchoolAsync(updateMaterialToSchoolRequest);
        //    return Ok(new ResponseResult { Message = "You succeeded" });
        //}

        //[HttpDelete]
        //[Authorize(Roles = Role.Administrator)]
        //public async Task<IActionResult> DeleteMaterialForSchool(int id)
        //{
        //    await _materialSchoolService.DeleteMaterialForSchoolAsync(id);
        //    return Ok(new ResponseResult { Message = "You succeeded" });
        //}
    }
}
