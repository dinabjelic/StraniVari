using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolVolunteersController : BaseCRUDController<SchoolVolunteer, InsertVolunteerToSchoolRequest, UpdateVolunteerAssignedToSchoolRequest, GetVolunteersForSchoolResponse>
    {
        private readonly ISchoolVolunteerService _schoolVolunteerService;
        public SchoolVolunteersController(ISchoolVolunteerService schoolVolunteerService):base(schoolVolunteerService)
        {
            _schoolVolunteerService = schoolVolunteerService;
        }

        [HttpGet("get")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetVolunteersForSchool(int id)
        {
            return Ok(await _schoolVolunteerService.GetVolunteersForSchool(id));
        }

        [HttpGet("getEventVolunteers")]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> GetVolunteersForEvent(int id)
        {
            return Ok(await _schoolVolunteerService.GetVolunteersForEvent(id));
        }

        [HttpGet("getEventSchoolsVolunteers")]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> GetEventSchoolsVolunteers(int id)
        {
            return Ok(await _schoolVolunteerService.GetEventSchoolsVolunteers(id));
        }
    }
}
