using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class PlanAndProgrammeController : BaseCRUDController<PlanAndProgramme, UpSertPlanAndProgrammeRequest, UpSertPlanAndProgrammeRequest, GetPlanAndProgrameResposnse>
    {
        private readonly IPlanAndProgrammeService _planAndProgrammeService;

        public PlanAndProgrammeController(IPlanAndProgrammeService planAndProgrammeService) : base(planAndProgrammeService)
        {
            _planAndProgrammeService = planAndProgrammeService;
        }

        [HttpGet("planAndProgramme")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> PlanAndProgrammeList(int id)
        {
            return Ok(await _planAndProgrammeService.PlanAndProgrammeListAsync(id));
        }
    }
}
