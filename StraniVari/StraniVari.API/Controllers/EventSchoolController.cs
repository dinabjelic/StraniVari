﻿using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Requests;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class EventSchoolController : BaseApiController
    {
        private readonly IEventSchoolService _eventSchoolService;
        public EventSchoolController(IEventSchoolService eventSchoolService)
        {
            _eventSchoolService = eventSchoolService;
        }

        [HttpPost]
        public async Task<IActionResult> AddSchoolToEvent(EventSchoolInsertRequest addEventSchoolUpSertRequest)
        {
            await _eventSchoolService.AddSchoolToEventAsync(addEventSchoolUpSertRequest);
            return Ok("You succeeded");
        }

        [HttpGet]
        public async Task<IActionResult> SchoolsForEventList(int id)
        {
            return Ok(await _eventSchoolService.SchoolsForEventListAsync(id));
        }

        [HttpGet("School-Event details")]
        public async Task<IActionResult> EventSchoolDetails(int id)
        {
            return Ok(await _eventSchoolService.EventSchoolDetailsAsync(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSchoolForEvent(EventSchoolUpdateRequest eventSchoolUpdateRequest)
        {
            await _eventSchoolService.UpdateSchoolForEventAsync(eventSchoolUpdateRequest);
            return Ok("You succeeded");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSchoolForEvent(int id)
        {
            await _eventSchoolService.DeleteSchoolForEventAsync(id);
            return Ok("You succeeded");
        }
    }
}
