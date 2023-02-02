﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Dtos;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
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

        //[Authorize(Roles = "Administrator")]
        //[AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetEventDetails()
        {
            return Ok(await _eventService.GetEventDetailsAsync());
        }

        [HttpGet("event-details")]
        public async Task<IActionResult> GetEventDetailsById(int id)
        {
            return Ok(await _eventService.GetEventDetailsByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddEvent(EventUpsertRequest addEventRequest)
        {
            await _eventService.AddEventAsync(addEventRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEvent(int id, [FromBody] EventUpsertRequest updateEventRequest)
        {
            await _eventService.UpdateEventAsync(id, updateEventRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            await _eventService.DeleteEventAsync(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }
    }
}
