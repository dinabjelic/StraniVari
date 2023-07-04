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
    public class EventService : BaseCrudService<Event, EventUpsertRequestMapp, EventUpsertRequestMapp, GetEventDetailsResponse>, IEventService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public EventService(StraniVariDbContext straniVariDbContext, IMapper mapper) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task<List<GetEventDetailsResponse>> GetEventDetailsActiveYear(int userId)
        {
            var isVolunteer = await _straniVariDbContext.Volunteers.AnyAsync(x => x.Id == userId);

            var eventDetails = _straniVariDbContext.Events
                .AsQueryable();

            if (isVolunteer)
            {
                var volunteersEventIds = await _straniVariDbContext
                    .SchoolVolunteers
                    .Include(x => x.EventSchool)
                    .Where(x => x.VolunteerId == userId)
                    .Select(x => x.EventSchool.EventId)
                    .ToArrayAsync();

                eventDetails = eventDetails
                    .Where(x => volunteersEventIds.Contains(x.Id));
            }

            var result = await eventDetails
                .Select(x => new GetEventDetailsResponse
                {
                    Id = x.Id,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Name = x.Name,
                    StraniVariTheme = x.StraniVariTheme
                }).ToListAsync();

            return result;
        }

        public async Task<GetEventDetailsResponse> GetLastAddedEvent()
        {
            var lastAdded = await _straniVariDbContext.Events
                .OrderBy(x => x.StartDate.Year).
                Select(x => new GetEventDetailsResponse
                {
                    Id = x.Id,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Name = x.Name,
                    StraniVariTheme = x.StraniVariTheme
                }).LastOrDefaultAsync();

            return lastAdded;
        }
        public async Task<List<EventUpsertRequest>> GetFilteredEvents(string searchTerm)
        {
            var filteredData = await _straniVariDbContext.Events.Select(x=> new EventUpsertRequest
            {
                Id= x.Id, 
                Name = x.Name, 
                EndDate = x.EndDate, 
                StartDate = x.StartDate, 
                StraniVariTheme = x.StraniVariTheme
            }).ToListAsync();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                filteredData = filteredData.Where(x => (x.Name + " " + x.StraniVariTheme).ToLower().Contains(searchTerm.ToLower())).ToList();
            }

            return filteredData;
        }
    }
}
