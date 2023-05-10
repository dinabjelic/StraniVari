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

        [HttpGet("details")]
        public override async Task<IActionResult> GetById(int id)
        {
            return Ok(await _volunteerTripService.GetById(id));
        }

        [HttpGet("trip-status-for-event")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetTripStatusForEvent(int id)
        {
            return Ok(await _volunteerTripService.GetTripStatusForEvent(id));
        }

        [HttpPut]
        public override async Task<IActionResult> Update(int id, VolunteerTripUpdateRequest volunteerTripUpdateRequest)
        {
            await base.Update(id, volunteerTripUpdateRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
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
