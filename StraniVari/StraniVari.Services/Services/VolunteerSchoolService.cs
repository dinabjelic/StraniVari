using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class VolunteerSchoolService : IVolunteerSchoolService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public VolunteerSchoolService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task<List<GetSchoolsAssignedDetailsResponse>> GetSchoolsAssignedToVolunteerAsync(int id, int year)
        {
            var schoolList = await _straniVariDbContext.SchoolVolunteers.Where(x => x.VolunteerId == id)
                .Where(x=>x.VolunteeringYear==year)
                .Select(x => new GetSchoolsAssignedDetailsResponse
                {
                    Name = x.Schools.Name,
                    Address = x.Schools.Address,
                    City = x.Schools.City,
                }).ToListAsync();
            return schoolList;
        }

        public async Task<List<GetVolunteerShoolDetailsResponse>> GetVoluntersListForChoosenSchoolAsync(int id, int year)
        {
            var volunteersList = await _straniVariDbContext.SchoolVolunteers
                .Where(x => x.SchoolId == id && x.VolunteeringYear==year)
                .Select(x => new GetVolunteerShoolDetailsResponse
                {
                    //SchoolId = x.SchoolId,
                    FirstName = x.Volunteers.FirstName,
                    LastName = x.Volunteers.LastName,
                    ShoolName = x.Schools.Name, 
                    Address= x.Volunteers.Address, 
                    City=x.Volunteers.City, 
                    VolunteeringYear =x.VolunteeringYear,
                    TransportNeeded= x.TransportNeeded
                }).ToListAsync();

            return volunteersList;
        }

        public async Task<List<GetVolunteerShoolDetailsResponse>> VolunteerSchoolListAsync(int year)
        {
            var volunteerSchoolList = await _straniVariDbContext.SchoolVolunteers
                 .Where(x=>x.VolunteeringYear==year)
                 .Select(x => new GetVolunteerShoolDetailsResponse
                 {
                     FirstName = x.Volunteers.FirstName,
                     LastName = x.Volunteers.LastName,
                     ShoolName = x.Schools.Name,
                     Address = x.Volunteers.Address,
                     City = x.Volunteers.City,
                     TransportNeeded = x.TransportNeeded
                 }).ToListAsync();

            return volunteerSchoolList;
        }

        public async Task AddVolunteersToSchoolAsync(VolunteerSchoolUpSertRequest addVolunteersToSchool)
        {
            var schoolFound = await _straniVariDbContext.Schools.FirstOrDefaultAsync(x => x.Id == addVolunteersToSchool.SchoolId);

            if (schoolFound == null)
            {
                throw new ArgumentException("Invalid request");
            }

            foreach (var item in addVolunteersToSchool.Volunters)
            {
                await _straniVariDbContext.SchoolVolunteers.AddAsync(new SchoolVolunteer
                {
                    SchoolId = schoolFound.Id,
                    VolunteerId = item.VolunteerId,
                    TransportNeeded = item.TransportNeeded,
                    VolunteeringYear = item.VolunteeringYear, 
                });
            }
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task RemoveVolunteersFromSchoolAsync(VolunteerSchoolDeleteRequest volunteerSchoolDeleteRequest)
        {
            var volunteerFound = _straniVariDbContext.SchoolVolunteers
                .Where(x => x.VolunteerId == volunteerSchoolDeleteRequest.VolunteerId &&
                x.SchoolId == volunteerSchoolDeleteRequest.SchoolId &&
                x.VolunteeringYear == volunteerSchoolDeleteRequest.VolunteeringYear);

            if(volunteerFound == null)
            {
                throw new ArgumentException("Invalid request");
            }

            foreach (var item in volunteerFound)
            {
                _straniVariDbContext.SchoolVolunteers.Remove(item);
            }

            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
