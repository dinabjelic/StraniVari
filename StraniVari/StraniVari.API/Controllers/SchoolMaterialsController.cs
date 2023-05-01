using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolMaterialsController : Base_CRUDController<SchoolMaterial, InsertMaterialToSchoolRequest, UpdateMaterialToSchoolRequest, GetMaterialsForSchoolRequest>
    {
        private readonly IMaterialSchoolService _materialSchoolService;
        public SchoolMaterialsController(IMaterialSchoolService materialSchoolService) : base(materialSchoolService)
        {
            _materialSchoolService = materialSchoolService;
        }

        [HttpPost]
        [Authorize(Roles = Role.Administrator)]
        public override async Task<IActionResult> Insert(InsertMaterialToSchoolRequest insertMaterialToSchoolRequest)
        {
            await base.Insert(insertMaterialToSchoolRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpGet("{eventSchoolId}/recommend")]
        [Authorize(Roles = Role.Administrator)]
        public IActionResult RecommendSystem(int eventSchoolId)
        {
            return Ok(_materialSchoolService.Recommend(eventSchoolId));
        }

        [HttpGet("details")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public override async Task<IActionResult> GetById(int id)
        {
            return Ok(await _materialSchoolService.GetById(id));
        }

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
