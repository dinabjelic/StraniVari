﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolMaterialsController : BaseCRUDController<SchoolMaterial, InsertMaterialToSchoolRequest, UpdateMaterialToSchoolRequest, GetMaterialsForSchoolRequest>
    {
        private readonly IMaterialSchoolService _materialSchoolService;
        public SchoolMaterialsController(IMaterialSchoolService materialSchoolService) : base(materialSchoolService)
        {
            _materialSchoolService = materialSchoolService;
        }

        [HttpGet("{eventSchoolId}/recommend")]
        [Authorize(Roles = Role.Administrator)]
        public IActionResult RecommendSystem(int eventSchoolId)
        {
            return Ok(_materialSchoolService.Recommend(eventSchoolId));
        }

        [HttpGet("details")]
        public override async Task<IActionResult> GetById(int id)
        {
            return Ok(await _materialSchoolService.GetById(id));
        }
    }
}
