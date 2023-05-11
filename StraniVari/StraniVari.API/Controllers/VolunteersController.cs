using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class VolunteersController : BaseCRUDController<Volunteer, VolunteerUpSertRequest, VolunteerUpSertRequest, GetVolunteerDetailsResposne>
    {
        private readonly IVolunteerService _volunteerService;
        public VolunteersController(IVolunteerService volunteerService):base(volunteerService)
        {
            _volunteerService = volunteerService;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAll()
        {
            return Ok(await _volunteerService.GetAll());
        }

        [HttpGet("details")]
        public override async Task<IActionResult> GetById(int id)
        {
            return Ok(await _volunteerService.GetById(id));
        }

        [HttpPost]
        public override async Task<IActionResult> Insert(VolunteerUpSertRequest addVolunteerRequest)
        {
            await base.Insert(addVolunteerRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpPut]
        public override async Task<IActionResult> Update(int id, [FromBody]VolunteerUpSertRequest updateVolunteerRequest)
        {
            await base.Update(id, updateVolunteerRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }
    }
}
