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
                StartDate = addEventRequest.StartDate,
                EndDate = addEventRequest.EndDate, 
                StraniVariTheme = addEventRequest.StraniVariTheme, 
                Name = addEventRequest.Name
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
                    StartDate = x.StartDate, 
                    EndDate =x.EndDate, 
                    Name= x.Name, 
                    StraniVariTheme = x.StraniVariTheme
                }).ToListAsync();

            return eventDetails;
        }

        public async Task<List<GetEventDetailsResponse>> GetEventDetailsActiveYear()
        {
            var eventDetails = await _straniVariDbContext.Events
                               .Where(x=>x.EndDate.Year == DateTime.Now.Year)
                               .Select(x => new GetEventDetailsResponse
                               {
                                   Id = x.Id,
                                   StartDate = x.StartDate,
                                   EndDate = x.EndDate,
                                   Name = x.Name,
                                   StraniVariTheme = x.StraniVariTheme
                               }).ToListAsync();
            return eventDetails;
        }

        public async Task<List<GetEventDetailsByIdResponse>> GetEventDetailsByIdAsync(int id)
        {
            var eventDetails = await _straniVariDbContext.Events
                .Where(x=>x.Id == id)
                .Select(x => new GetEventDetailsByIdResponse
                {
                    //Id = x.Id,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Name = x.Name,
                    StraniVariTheme = x.StraniVariTheme
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

            eventFound.StartDate = addEventRequest.StartDate;
            eventFound.EndDate = addEventRequest.EndDate;
            eventFound.Name = addEventRequest.Name;
            eventFound.StraniVariTheme = addEventRequest.StraniVariTheme;

            _straniVariDbContext.Events.Update(eventFound);
            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
