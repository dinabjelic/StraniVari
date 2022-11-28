using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Requests;
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
        public async Task<IActionResult> GetVolunteers()
        {
            return Ok(await _volunteerService.VolunteerListAsync());
        }

        [HttpGet("volunteer-details")]
        public async Task<IActionResult> GetVolunteerDetails(int id)
        {
            return Ok(await _volunteerService.GetVolunteerDetailsAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddVolunteer(VolunteerUpSertRequest addVolunteerRequest)
        {
            await _volunteerService.AddVolunteerAsync(addVolunteerRequest);
            return Ok("You succeeded");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateVolunteer(int id, [FromBody]VolunteerUpSertRequest updateVolunteerRequest)
        {
            await _volunteerService.UpdateVolunteerAsync(id, updateVolunteerRequest);
            return Ok("You succeeded");
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteVolunteer(int id)
        {
            await _volunteerService.DeleteVolunteerAsync(id);
            return Ok("You succeeded");
        }
    }
}
