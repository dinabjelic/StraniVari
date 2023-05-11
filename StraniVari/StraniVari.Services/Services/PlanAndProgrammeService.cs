using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class PlanAndProgrammeService : BaseCrudService<PlanAndProgramme, UpSertPlanAndProgrammeRequest, UpSertPlanAndProgrammeRequest, GetPlanAndProgrameResposnse>, IPlanAndProgrammeService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public PlanAndProgrammeService(StraniVariDbContext straniVariDbContext, IMapper mapper) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }
        public async Task<List<GetPlanAndProgrameResposnse>> PlanAndProgrammeListAsync(int id)
        {
            var planAndProgrameList = await _straniVariDbContext.PlanAndProgramme
                .Include(x => x.Event)
                .Where(x =>x.EventId == id)
                .Select(x => new GetPlanAndProgrameResposnse
                {
                    Id = x.Id,
                    DayOfWeek = x.DayOfWeek,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Activity = x.Activity,
                }).ToListAsync();

            return planAndProgrameList;
        }
    }
}
