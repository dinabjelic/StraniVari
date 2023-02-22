using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Common.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class VolunteersController : BaseApiController
    {
        private readonly IVolunteerService _volunteerService;
        public VolunteersController(IVolunteerService volunteerService)
        {
            _volunteerService = volunteerService;
        }

        [HttpGet]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetVolunteers()
        {
            return Ok(await _volunteerService.VolunteerListAsync());
        }

        [HttpGet("volunteer-details")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetVolunteerDetails(int id)
        {
            return Ok(await _volunteerService.GetVolunteerDetailsAsync(id));
        }

        [HttpPost]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> AddVolunteer(VolunteerUpSertRequest addVolunteerRequest)
        {
            await _volunteerService.AddVolunteerAsync(addVolunteerRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpPut]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> UpdateVolunteer(int id, [FromBody]VolunteerUpSertRequest updateVolunteerRequest)
        {
            await _volunteerService.UpdateVolunteerAsync(id, updateVolunteerRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpDelete]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> DeleteVolunteer(int id)
        {
            await _volunteerService.DeleteVolunteerAsync(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }
    }
}
