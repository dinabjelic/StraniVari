﻿using Microsoft.AspNetCore.Authorization;
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

        [HttpPost]
        public override async Task<IActionResult> Insert([FromBody] EventSchoolInsertRequest addEventSchoolUpSertRequest)
        {
            await base.Insert(addEventSchoolUpSertRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpGet("details")]
        public override async Task<IActionResult> GetById(int id)
        {
            return Ok(await _eventSchoolService.GetById(id));
        }
    }
}
