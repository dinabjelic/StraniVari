using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class EventSchoolService : IEventSchoolService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public EventSchoolService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task AddSchoolToEventAsync(EventSchoolInsertRequest addEventSchoolInsertRequest)
        {
            var eventFound = await _straniVariDbContext.Events.FirstOrDefaultAsync(x => x.Id == addEventSchoolInsertRequest.EventId);

            foreach(var item in addEventSchoolInsertRequest.Schools)
            {
                await _straniVariDbContext.EventSchools.AddAsync(new EventSchool
                {
                    EventId = eventFound.Id,
                    SchoolId = item
                });
            }

            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task DeleteSchoolForEventAsync(int id)
        {
            var schoolFound = await _straniVariDbContext.EventSchools.FirstOrDefaultAsync(x => x.Id == id);

            if (schoolFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _straniVariDbContext.EventSchools.Remove(schoolFound);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetEventSchoolDetailsResponse>> EventSchoolDetailsAsync(int id)
        {
            var schoolEventDetails = await _straniVariDbContext.EventSchools
                .Where(x=>x.Id ==id)
                .Select(x => new GetEventSchoolDetailsResponse
                {
                    EndDate = x.Event.EndDate,
                    StartDate = x.Event.StartDate,
                    StraniVariTheme = x.Event.StraniVariTheme,
                    EventName = x.Event.Name,
                    SchoolAddress = x.School.Address,
                    SchoolCity = x.School.City,
                    SchoolName = x.School.Name
                }).ToListAsync();

            return schoolEventDetails;    
        }

        public async Task<List<GetSchoolsForEventResponse>> SchoolsForEventListAsync(int id)
        {
            var schoolForEvent = await _straniVariDbContext.EventSchools
                .Include(x => x.Event)
                .Where(x=>x.EventId == id)
                .Select(x => new GetSchoolsForEventResponse
                {
                    SchoolEventId = x.Id,
                    //EventName = x.Event.Name,
                    NumberOfChildren = x.NumberOfChildren,
                    //StartDate = x.Event.StartDate,
                    //EndDate = x.Event.EndDate,
                    //StraniVariTheme = x.Event.StraniVariTheme,
                    SchoolAddress = x.School.Name,
                    SchoolCity = x.School.City,
                    SchoolName = x.School.Name
                }).ToListAsync();

            return schoolForEvent;
        }

        public async Task UpdateSchoolForEventAsync(EventSchoolUpdateRequest eventSchoolUpdateRequest)
        {
            if (eventSchoolUpdateRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var eventSchoolFound = await _straniVariDbContext.EventSchools.FirstOrDefaultAsync(x => x.Id == eventSchoolUpdateRequest.EventSchoolId);

            if (eventSchoolFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            eventSchoolFound.NumberOfChildren = eventSchoolUpdateRequest.NumberOfChildren;

            _straniVariDbContext.EventSchools.Update(eventSchoolFound);
            await _straniVariDbContext.SaveChangesAsync();
            
        }
    }
}
