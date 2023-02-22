﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Common.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolsController : BaseApiController
    {
        private readonly ISchoolService _schoolService;

        public SchoolsController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetSchoolList()
        {
            return Ok(await _schoolService.SchoolListAsync());
        }

        [HttpGet("school-details")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetSchoolDetails(int id)
        {
            return Ok(await _schoolService.GetSchoolDetailsAsync(id));
        }

        [HttpDelete]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> DeleteSchool(int id)
        {
            await _schoolService.DeleteSchoolAsync(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpPost]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> AddSchool(SchoolUpsertRequest addSchoolRequest)
        {
            await _schoolService.AddSchoolAsync(addSchoolRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpPut]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> UpdateSchool(int id, [FromBody] SchoolUpsertRequest updateSchoolRequest)
        {
            await _schoolService.UpdateSchoolAsync(id, updateSchoolRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }
    }
}
