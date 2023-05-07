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

        [HttpPut]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> Update(int id, VolunteerTripUpsertRequest rew)
        {
            await _volunteerTripService.UpdateVolunteerDetailsAsync(id,rew);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }
    }
}
