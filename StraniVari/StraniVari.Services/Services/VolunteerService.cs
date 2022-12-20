using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class VolunteerService:IVolunteerService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public VolunteerService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task AddVolunteerAsync(VolunteerUpSertRequest addVolunteerRequest)
        {
            var newVolunteer = new Volunteer
            {
                FirstName = addVolunteerRequest.FirstName,
                LastName = addVolunteerRequest.LastName,
                Address = addVolunteerRequest.Address,
                City = addVolunteerRequest.City,
                DateOfBirth = addVolunteerRequest.DateOfBirth,
                StartDateOfVolunteering = addVolunteerRequest.StartDateOfVolunteering
            };

            await _straniVariDbContext.Volunteers.AddAsync(newVolunteer);
            await _straniVariDbContext.SaveChangesAsync();

        }

        public async Task DeleteVolunteerAsync(int id)
        {
            var volunteer = await _straniVariDbContext.Volunteers.FirstOrDefaultAsync(x => x.Id == id);

            if(volunteer==null)
            {
                throw new ArgumentException("Invalid id");
            }

            _straniVariDbContext.Volunteers.Remove(volunteer);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<GetVolunteerDetailsResposne> GetVolunteerDetailsAsync(int id)
        {
            var volunteerDetails = await _straniVariDbContext.Volunteers
                .Select(x => new GetVolunteerDetailsResposne
                {
                    Id = x.Id,
                    FirstName = x.FirstName + " " + x.LastName + " " + x.Address + " " + x.City,
                    LastName = x.LastName,
                    Address = x.Address,
                    City = x.City,
                    DateOfBirth = x.DateOfBirth,
                    StartDateOfVolunteering = x.StartDateOfVolunteering
                }).FirstOrDefaultAsync(x => x.Id == id);

            return volunteerDetails;
        }

        public async Task UpdateVolunteerAsync(int id, VolunteerUpSertRequest updateVolunteerRequest)
        {
            if (updateVolunteerRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var volunteerFound = await _straniVariDbContext.Volunteers.FirstOrDefaultAsync(x => x.Id == id);

            if(volunteerFound==null)
            {
                throw new ArgumentException("Invalid id");
            }

            volunteerFound.FirstName = updateVolunteerRequest.FirstName;
            volunteerFound.LastName = updateVolunteerRequest.LastName;
            volunteerFound.Address = updateVolunteerRequest.Address;
            volunteerFound.City = updateVolunteerRequest.City;
            volunteerFound.DateOfBirth = updateVolunteerRequest.DateOfBirth;
            volunteerFound.StartDateOfVolunteering = updateVolunteerRequest.StartDateOfVolunteering;

            _straniVariDbContext.Volunteers.Update(volunteerFound);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetVolunteerDetailsResposne>> VolunteerListAsync()
        {
            var volunteerList = await _straniVariDbContext.Volunteers.Select(x => new GetVolunteerDetailsResposne
            {
                Id = x.Id,
                //FirstName = x.FirstName + " " + x.LastName + " " + x.Address + " " + x.City,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                City = x.City,
                DateOfBirth = x.DateOfBirth,
                StartDateOfVolunteering = x.StartDateOfVolunteering, 
            }).ToListAsync();

            return volunteerList;
        }
    }
}
