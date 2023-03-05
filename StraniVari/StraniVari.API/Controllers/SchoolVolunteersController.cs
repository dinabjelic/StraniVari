using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolVolunteersController : BaseApiController
    {
        private readonly ISchoolVolunteerService _schoolVolunteerService;
        public SchoolVolunteersController(ISchoolVolunteerService schoolVolunteerService)
        {
            _schoolVolunteerService = schoolVolunteerService;
        }

        [HttpPost]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> AddVolunteerToSchool(InsertVolunteerToSchoolRequest insertVolunteerToSchoolRequest)
        {
            await _schoolVolunteerService.AddVolunteerToSchoolAsync(insertVolunteerToSchoolRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpGet]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> SchoolVolunteerList(int id)
        {
            return Ok(await _schoolVolunteerService.SchoolVolunteerListAsync(id));
        }

        [HttpPut]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> UpdateVolunteerDetails(UpdateVolunteerAssignedToSchoolRequest updateVolunteerAssignedToSchoolRequest)
        {
            await _schoolVolunteerService.UpdateVolunteerDetailsAsync(updateVolunteerAssignedToSchoolRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpDelete]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> DeleteVolunteerFromSchool(int id)
        {
            await _schoolVolunteerService.DeleteVolunteerFromSchoolAsync(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }
    }
}
