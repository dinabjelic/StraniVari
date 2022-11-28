using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Requests;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class PlanAndProgrammeController : BaseApiController
    {
        private readonly IPlanAndProgrammeService _planAndProgrammeService;

        public PlanAndProgrammeController(IPlanAndProgrammeService planAndProgrammeService)
        {
            _planAndProgrammeService = planAndProgrammeService;
        }

        [HttpPost]
        public async Task<IActionResult> AddPlanAndProgramme(UpSertPlanAndProgrammeRequest addPlanAndProgrammeRequest)
        {
            await _planAndProgrammeService.AddPlanAndProgrammeAsync(addPlanAndProgrammeRequest);
            return Ok("You succeeded");
        }

        [HttpGet]
        public async Task<IActionResult> PlanAndProgrammeList(DayOfWeek dayOfWeek)
        {
            return Ok(await _planAndProgrammeService.PlanAndProgrammeListAsync(dayOfWeek));
        }
    }
}
