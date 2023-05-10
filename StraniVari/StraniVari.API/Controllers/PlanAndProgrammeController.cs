using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class PlanAndProgrammeController : BaseCRUDController<PlanAndProgramme, UpSertPlanAndProgrammeRequest, UpSertPlanAndProgrammeRequest, GetPlanAndProgrameResposnse>
    {

        public PlanAndProgrammeController(IPlanAndProgrammeService planAndProgrammeService) : base(planAndProgrammeService)
        {
        }
    }
}
