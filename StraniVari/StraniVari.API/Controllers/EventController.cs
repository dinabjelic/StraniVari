using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Requests;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class EventController : BaseApiController
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<IActionResult> GetEventDetails()
        {
            return Ok(await _eventService.GetEventDetailsAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddEvent(EventUpsertRequest addEventRequest)
        {
            await _eventService.AddEventAsync(addEventRequest);
            return Ok("You succeeded");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEvent(int id, [FromBody] EventUpsertRequest updateEventRequest)
        {
            await _eventService.UpdateEventAsync(id, updateEventRequest);
            return Ok("You succeeded");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            await _eventService.DeleteEventAsync(id);
            return Ok("You succeeded");
        }
    }
}
