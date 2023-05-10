using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;
using System.Security.Claims;


namespace StraniVari.Services.Services
{
    public class VolunteerTripService : BaseCrudService<VolunteerTrip, VolunteerTripInsertRequest, VolunteerTripUpdateRequest, GetTripApplicationsResponse>, IVolunteerTripService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        public VolunteerTripService(StraniVariDbContext straniVariDbContext, IHttpContextAccessor httpContextAccessor, UserManager<User> userManager, IMapper mapper):base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }
        public override async Task Insert(VolunteerTripInsertRequest volunteerTripInsertRequest)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var user = await _userManager.FindByIdAsync(userId);
            var roles = await _userManager.GetRolesAsync(user);


            var tripFound = await _straniVariDbContext.Trips.FirstOrDefaultAsync(x => x.EventId == volunteerTripInsertRequest.EventId);

            if(tripFound is not null)
            {
                if (!roles.Contains("Administrator"))
                {
                    var newApplication = new VolunteerTrip
                    {
                        StatusId = 3,
                        VolunteerId = int.Parse(userId),
                        TripId = tripFound.Id,
                    };
                    await _straniVariDbContext.VolunteerTrip.AddAsync(newApplication);
                    await _straniVariDbContext.SaveChangesAsync();
                }
            }
        }

        public async Task<List<GetTripApplicationsResponse>> GetById(int id)
        {
            var tripsApplications = await _straniVariDbContext.VolunteerTrip
                .Where(x => x.Trip.EventId == id)
                .Select(x => new GetTripApplicationsResponse
                {
                    Id = x.Id,
                    VolunteerId = x.VolunteerId,
                    VolunteerName = x.Volunteer.FirstName,
                    VolunteerLastName = x.Volunteer.LastName,
                    Status = x.Status.Status,
                    StatusId = x.StatusId
                }).ToListAsync();

            return tripsApplications;
        }

        public async Task<GetTripsDetailsForEventResponse> GetTripStatusForEvent(int id)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            var status = await _straniVariDbContext.VolunteerTrip.
                Where(x => x.Trip.EventId == id && x.VolunteerId == int.Parse(userId))
                .Select(x => new GetTripsDetailsForEventResponse
                {
                    Place = x.Trip.Place,
                    TripDateTime = x.Trip.TripDateTime,
                    Id = x.Id,
                    Status = x.Status.Status
                }).FirstOrDefaultAsync();

            return status;
        }
    }
}
