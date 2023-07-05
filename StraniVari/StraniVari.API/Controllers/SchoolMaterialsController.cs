using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolMaterialsController : BaseCRUDController<SchoolMaterial, InsertMaterialToSchoolRequest, UpdateMaterialToSchoolRequest, GetMaterialsForSchoolRequest>
    {
        private readonly IMaterialSchoolService _materialSchoolService;
        public SchoolMaterialsController(IMaterialSchoolService materialSchoolService) : base(materialSchoolService)
        {
            _materialSchoolService = materialSchoolService;
        }

        [HttpGet("{eventSchoolId}/recommend")]
        [Authorize(Roles = Role.Administrator)]
        public IActionResult RecommendSystem(int eventSchoolId)
        {
            return Ok(_materialSchoolService.Recommend(eventSchoolId));
        }

        [HttpGet("get")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetMaterialsForSchool(int id)
        {
            return Ok(await _materialSchoolService.GetMaterialsForSchool(id));
        }

        [HttpGet("getActiveMaterial")]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> GetAvailableMaterial(int id)
        {
            return Ok(await _materialSchoolService.GetAvailableMaterial(id));
        }

        [HttpGet("getEventSchoolsMaterial")]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> GetEventSchoolsMaterial(int id)
        {
            return Ok(await _materialSchoolService.GetEventSchoolsMaterial(id));
        }
    }
}
