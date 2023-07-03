using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class EventSchoolController : BaseCRUDController<EventSchool, EventSchoolInsertRequest, EventSchoolUpdateRequest, GetSchoolsForEventResponse>
    {
        private readonly IEventSchoolService _eventSchoolService;
        public EventSchoolController(IEventSchoolService eventSchoolService):base(eventSchoolService)
        {
            _eventSchoolService = eventSchoolService;
        }

        [HttpGet("get")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetSchoolsForEvent(int id)
        {
            return Ok(await _eventSchoolService.GetSchoolsForEvent(id));
        }

        [HttpGet("getActiveSchools")]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> GetAvailableSchools(int id)
        {
            return Ok(await _eventSchoolService.GetAvailableSchools(id));
        }
    }
}
