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

        [HttpGet("details")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetVolunteersForSchool(int id)
        {
            return Ok(await _schoolVolunteerService.GetVolunteersForSchool(id));
        }
    }
}
