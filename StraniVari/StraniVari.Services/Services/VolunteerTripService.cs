using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class VolunteerTripService : IVolunteerTripService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public VolunteerTripService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
        }
        public async Task<List<GetTripApplicationsResponse>> GetTripApplications(int id)
        {
            var tripsApplications = await _straniVariDbContext.VolunteerTrip
                .Where(x=>x.Trip.EventId == id)
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
        public async Task UpdateVolunteerDetailsAsync(int id,VolunteerTripUpsertRequest updateApplicationStatus)
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
    }
}
