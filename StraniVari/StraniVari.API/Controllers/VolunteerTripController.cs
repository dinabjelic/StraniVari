using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class VolunteerTripController : BaseCRUDController<VolunteerTrip, VolunteerTripInsertRequest, VolunteerTripUpdateRequest, GetTripApplicationsResponse>
    {
        private readonly IVolunteerTripService _volunteerTripService;
        public VolunteerTripController(IVolunteerTripService volunteerTripService):base(volunteerTripService)
        {
            _volunteerTripService = volunteerTripService;
        }

        [HttpGet("get")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetTripApplications(int id)
        {
            return Ok(await _volunteerTripService.GetTripApplications(id));
        }

        [HttpGet("trip-status-for-event")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetTripStatusForEvent(int id)
        {
            return Ok(await _volunteerTripService.GetTripStatusForEvent(id));
        }
   
        [HttpPost("insert")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> Insert([FromQuery]VolunteerTripInsertRequest volunteerTripInsertRequest)
        {
            await base.Insert(volunteerTripInsertRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }
    }
}
