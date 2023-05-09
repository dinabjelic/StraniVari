using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;
using System.Security.Claims;

namespace StraniVari.Services.Services
{
    public class VolunteerTripService : IVolunteerTripService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public VolunteerTripService(StraniVariDbContext straniVariDbContext, IHttpContextAccessor httpContextAccessor)
        {
            _straniVariDbContext = straniVariDbContext;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task Insert(int tripId)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(x => x.Type == ClaimTypes.NameIdentifier);
            //bool isRecordExists = await _straniVariDbContext.VolunteerTrip
            //.AnyAsync(x=>x.VolunteerId == int.Parse(userId.Value) && x.TripId == tripId);

            //if (!isRecordExists)
            //{
                var newApplication = new VolunteerTrip
                {
                    StatusId = 3,
                    VolunteerId = int.Parse(userId.Value),
                    TripId = tripId
                };
              await _straniVariDbContext.VolunteerTrip.AddAsync(newApplication);
        //}
        await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetTripApplicationsResponse>> GetTripApplications(int id)
        {
            var tripsApplications = await _straniVariDbContext.VolunteerTrip
                .Where(x => x.Trip.EventId == id)
                .Select(x => new GetTripApplicationsResponse
                {
                    VolunteerId = x.VolunteerId,
                    VolunteerName = x.Volunteer.FirstName,
                    VolunteerLastName = x.Volunteer.LastName,
                    Status = x.Status.Status,
                    StatusId = x.StatusId
                }).ToListAsync();

            return tripsApplications;
        }
        public async Task UpdateVolunteerDetailsAsync(int id, VolunteerTripUpsertRequest updateApplicationStatus)
        {
            if (updateApplicationStatus == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var volunteerFound = await _straniVariDbContext.VolunteerTrip.FirstOrDefaultAsync(x => x.VolunteerId == id);

            if (volunteerFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            volunteerFound.StatusId = updateApplicationStatus.StatusId;

            _straniVariDbContext.VolunteerTrip.Update(volunteerFound);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<GetTripsDetailsForEvent> GetTripStatusForLoggedInUser(int id)
        {
            var status = await _straniVariDbContext.Trips
                .Where(x=>x.EventId == id)
                .Select(x => new GetTripsDetailsForEvent
                {
                    Place = x.Place,
                    TripDateTime = x.TripDateTime,
                    Id = x.Id,
                }).FirstOrDefaultAsync();

            return status;
        }
    }
}
