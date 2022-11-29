using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class PlanAndProgrammeService : IPlanAndProgrammeService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public PlanAndProgrammeService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
        }
        public async Task AddPlanAndProgrammeAsync(UpSertPlanAndProgrammeRequest addPlanAndProgrammeRequest)
        {
            var newPlanAndProgramme = new PlanAndProgramme
            {
                Activity = addPlanAndProgrammeRequest.Activity,
                ActivityDateTime = addPlanAndProgrammeRequest.ActivityDateTime,
                DayOfWeek = addPlanAndProgrammeRequest.DayOfWeek,
                StraniVariThemeId = addPlanAndProgrammeRequest.StraniVariThemeId
            };

            await _straniVariDbContext.PlanAndProgramme.AddAsync(newPlanAndProgramme);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetPlanAndProgrameResposnse>> PlanAndProgrammeListAsync(DayOfWeek? dayOfWeek, string? StraniVariTheme)
        {
            var planAndProgrameList = await _straniVariDbContext.PlanAndProgramme
                .Where(x => x.DayOfWeek == dayOfWeek || dayOfWeek== null
                || x.StraniVariTheme.Theme == StraniVariTheme)
                .Select(x => new GetPlanAndProgrameResposnse
                {
                    Activity = x.Activity,
                    DayOfWeek = x.DayOfWeek,
                    ActivityDateTime = x.ActivityDateTime,
                }).ToListAsync();

            return planAndProgrameList;
        }

        public async Task UpdatePlanAndProgrammeAsync(int id, UpSertPlanAndProgrammeRequest updatePlanAndProgrammeRequest)
        {
            if (updatePlanAndProgrammeRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var planFound = await _straniVariDbContext.PlanAndProgramme.FirstOrDefaultAsync(x => x.Id == id);

            if (planFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            planFound.Activity = updatePlanAndProgrammeRequest.Activity;
            planFound.ActivityDateTime = updatePlanAndProgrammeRequest.ActivityDateTime;
            planFound.DayOfWeek = updatePlanAndProgrammeRequest.DayOfWeek;

            _straniVariDbContext.PlanAndProgramme.Update(planFound);
            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
