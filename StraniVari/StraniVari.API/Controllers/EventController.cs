using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;
using System.Security.Claims;

namespace StraniVari.API.Controllers
{
    public class EventController : BaseCRUDController<Event, EventUpsertRequestMapp, GetEventDetailsResponse>
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService):base(eventService)
        {
            _eventService = eventService;
        }

        [HttpGet("event-details-for-active-year")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetEventDetailsForActiveYear()
        {
            var userId = HttpContext.User.FindFirst(x => x.Type == ClaimTypes.NameIdentifier);
            return Ok(await _eventService.GetEventDetailsActiveYear(int.Parse(userId.Value)));
        }

        [HttpGet("last-added-event")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetLastAddedEvent()
        {
            return Ok(await _eventService.GetLastAddedEvent());
        }
    }
}
