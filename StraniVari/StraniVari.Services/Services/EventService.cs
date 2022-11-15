using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class EventService : IEventService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public EventService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task AddEventAsync(EventUpsertRequest addEventRequest)
        {
            var newEvent = new Event
            {
                SchoolId = addEventRequest.SchoolId,
                NumberOfChildren = addEventRequest.NumberOfChildren,
                StartDate = addEventRequest.StartDate,
                EndDate = addEventRequest.EndDate
            };

            await _straniVariDbContext.Events.AddAsync(newEvent);
            await _straniVariDbContext.SaveChangesAsync(); 
        }

        public async Task DeleteEventAsync(int id)
        {
            var eventFound = await _straniVariDbContext.Events.FirstOrDefaultAsync(x => x.Id == id);

            if (eventFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _straniVariDbContext.Events.Remove(eventFound);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetEventDetailsResponse>> GetEventDetailsAsync()
        {
            var eventDetails = await _straniVariDbContext.Events
                .Select(x => new GetEventDetailsResponse
                {
                    Id = x.Id,
                    Name = x.Schools.Name,
                    NumberOfChildren = x.NumberOfChildren,
                    StartDateYear = x.StartDate.Year
                }).ToListAsync();

            return eventDetails;
        }

        public async Task UpdateEventAsync(int id, EventUpsertRequest addEventRequest)
        {
            if (addEventRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var eventFound = await _straniVariDbContext.Events.FirstOrDefaultAsync(x => x.Id == id);

            if(eventFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            eventFound.NumberOfChildren = addEventRequest.NumberOfChildren;
            eventFound.StartDate = addEventRequest.StartDate;
            eventFound.EndDate = addEventRequest.EndDate;
            eventFound.SchoolId = addEventRequest.SchoolId;

            _straniVariDbContext.Events.Update(eventFound);
            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
