using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolsVolunteersMaterialsController : BaseCRUDController<EventSchool, SchoolVolunteerMaterialRequest, SchoolVolunteerMaterialRequest, SchoolVolunteerMaterialRequest>
    {
        public SchoolsVolunteersMaterialsController(ISchoolsVolunteersMaterialsService  schoolsVolunteersMaterialsService) : base(schoolsVolunteersMaterialsService)
        {
        }

        [Authorize(Roles = Role.Administrator)]
        public override async Task<IActionResult> Insert(SchoolVolunteerMaterialRequest schoolVolunteerMaterialRequest)
        {
            await base.Insert(schoolVolunteerMaterialRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

    }
}
