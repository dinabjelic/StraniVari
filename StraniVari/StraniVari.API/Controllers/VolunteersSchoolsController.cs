using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Requests;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class VolunteersSchoolsController:BaseApiController
    {
        private readonly IVolunteerSchoolService _volunteerSchoolService;

        public VolunteersSchoolsController(IVolunteerSchoolService volunteerSchoolService)
        {
            _volunteerSchoolService = volunteerSchoolService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSchoolsVolunters(int year)
        {
            return Ok(await _volunteerSchoolService.VolunteerSchoolListAsync(year));
        } 

        [HttpGet("volunterListForChoosenSchool")]
        public async Task<IActionResult> GetSchoolVoluntersDetails(int id, int year)
        {
            return Ok(await _volunteerSchoolService.GetVoluntersListForChoosenSchoolAsync(id, year));
        }

        [HttpGet("schoolsListForChoosenVolunteer")]
        public async Task<IActionResult> GetSchoolsAssignedToVolunteer(int id, int year)
        {
            return Ok(await _volunteerSchoolService.GetSchoolsAssignedToVolunteerAsync(id, year));
        }

        //[HttpPost]
        //public async Task<IActionResult> AddVolunteerToSchool(VolunteerSchoolUpSertRequest volunteerSchoolUpSertRequest)
        //{
        //    await _volunteerSchoolService.AddVolunteerToSchoolAsync(volunteerSchoolUpSertRequest);
        //    return Ok("You succeeded");
        //}

        [HttpPost]
        public async Task<IActionResult> AddVolunteersToSchool(VolunteerSchoolUpSertRequest addVolunteersToSchool)
        {
            await _volunteerSchoolService.AddVolunteersToSchoolAsync(addVolunteersToSchool);
            return Ok("You succeeded");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveVolunteersFromSchool(VolunteerSchoolDeleteRequest volunteerSchoolDeleteRequest)
        {
            await _volunteerSchoolService.RemoveVolunteersFromSchoolAsync(volunteerSchoolDeleteRequest);
            return Ok("You succeeded");
        }
    }
}
