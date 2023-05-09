using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class VolunteerTripController : BaseApiController
    {
        private readonly IVolunteerTripService _volunteerTripService;
        public VolunteerTripController(IVolunteerTripService volunteerTripService)
        {
            _volunteerTripService = volunteerTripService;
        }

        [HttpGet]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _volunteerTripService.GetTripApplications(id));
        }

        [HttpGet("details")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetStatusForLoggedInVolunteer(int id)
        {
            return Ok(await _volunteerTripService.GetTripStatusForLoggedInUser(id));
        }

        [HttpPut]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> Update(int id, VolunteerTripUpsertRequest rew)
        {
            await _volunteerTripService.UpdateVolunteerDetailsAsync(id,rew);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpPost]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> Insert(int id)
        {
            await _volunteerTripService.Insert(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }
    }
}
