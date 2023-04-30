﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class PlanAndProgrammeController : BaseCRUDController<PlanAndProgramme, UpSertPlanAndProgrammeRequest, GetPlanAndProgrameResposnse>
    {
        private readonly IPlanAndProgrammeService _planAndProgrammeService;

        public PlanAndProgrammeController(IPlanAndProgrammeService planAndProgrammeService):base(planAndProgrammeService)
        {
            _planAndProgrammeService = planAndProgrammeService;
        }

        [HttpGet]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> PlanAndProgrammeList(DayOfWeek? dayOfWeek, int id)
        {
            return Ok(await _planAndProgrammeService.PlanAndProgrammeListAsync(dayOfWeek, id));
        }
        //[HttpPost]
        //[Authorize(Roles = Role.Administrator)]
        //public async Task<IActionResult> AddPlanAndProgramme(UpSertPlanAndProgrammeRequest addPlanAndProgrammeRequest)
        //{
        //    await _planAndProgrammeService.AddPlanAndProgrammeAsync(addPlanAndProgrammeRequest);
        //    return Ok(new ResponseResult { Message = "You succeeded" });
        //}

        //[HttpPut]
        //[Authorize(Roles = Role.Administrator)]
        //public async Task<IActionResult> UpdatePlanAndProgramme(int id, UpSertPlanAndProgrammeRequest updatePlanAndProgrammeRequest)
        //{
        //    await _planAndProgrammeService.UpdatePlanAndProgrammeAsync(id, updatePlanAndProgrammeRequest);
        //    return Ok(new ResponseResult { Message = "You succeeded" });
    }
    }
}
