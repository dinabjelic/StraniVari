using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolsController : BaseCRUDController<School, SchoolUpsertRequest, SchoolUpsertRequest, GetSchoolDetailsResponse>
    {
        private readonly ISchoolService _schoolService;
        public SchoolsController(ISchoolService schoolService):base(schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet("filtered-data")]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> GetFilteredSchools(string? searchTerm)
        {
            return Ok(await _schoolService.GetFilteredSchools(searchTerm));
        }
    }
}
