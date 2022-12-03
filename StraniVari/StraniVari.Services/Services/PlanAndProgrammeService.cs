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
                DayOfWeek = addPlanAndProgrammeRequest.DayOfWeek,
                StartDate = addPlanAndProgrammeRequest.StartDate, 
                EndDate = addPlanAndProgrammeRequest.EndDate,
                Activity = addPlanAndProgrammeRequest.Activity,
                EventId = addPlanAndProgrammeRequest.EventId, 
            };

            await _straniVariDbContext.PlanAndProgramme.AddAsync(newPlanAndProgramme);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetPlanAndProgrameResposnse>> PlanAndProgrammeListAsync(DayOfWeek? dayOfWeek)
        {
            var planAndProgrameList = await _straniVariDbContext.PlanAndProgramme
                //.Include(x=>x.Event)
                .Where(x => x.DayOfWeek == dayOfWeek || dayOfWeek== null)
                .Select(x => new GetPlanAndProgrameResposnse
                {
                    DayOfWeek = x.DayOfWeek,
                    StartDate = x.StartDate, 
                    EndDate =x.EndDate, 
                    Activity = x.Activity,
                    //EventName = x.Event.Name, 
                    //StraniVariTheme = x.Event.StraniVariTheme
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
            planFound.DayOfWeek = updatePlanAndProgrammeRequest.DayOfWeek;
            planFound.StartDate = updatePlanAndProgrammeRequest.StartDate;
            planFound.EndDate = updatePlanAndProgrammeRequest.EndDate;

            _straniVariDbContext.PlanAndProgramme.Update(planFound);
            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
