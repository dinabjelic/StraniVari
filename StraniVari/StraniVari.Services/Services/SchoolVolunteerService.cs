using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace StraniVari.Services.Services
{
    public class SchoolVolunteerService : BaseCrudService<SchoolVolunteer, InsertVolunteerToSchoolRequest, UpdateVolunteerAssignedToSchoolRequest, GetVolunteersForSchoolResponse>, ISchoolVolunteerService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public SchoolVolunteerService(StraniVariDbContext straniVariDbContext, IMapper mapper) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public override async Task Insert(InsertVolunteerToSchoolRequest insertVolunteerToSchoolRequest)
        {

            foreach(var item in insertVolunteerToSchoolRequest.Volunteers)
            {
                await _straniVariDbContext.SchoolVolunteers.AddAsync(new SchoolVolunteer
                {
                    EventSchoolId = insertVolunteerToSchoolRequest.EventSchoolId,
                    VolunteerId = item
                });
            }
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetVolunteersForSchoolResponse>> GetVolunteersForSchool(int id)
        {
            var schoolVolunteers = await _straniVariDbContext.SchoolVolunteers
                .Include(x => x.EventSchool)
                .Where(x => x.EventSchoolId == id)
                .Select(x => new GetVolunteersForSchoolResponse
                {
                    VolunteerId = x.VolunteerId,
                    SchoolVolunteerId = x.Id,
                    VolunteerAddress = x.Volunteer.Address,
                    VolunteerCity = x.Volunteer.City,
                    FirstName = x.Volunteer.FirstName,
                    LastName = x.Volunteer.LastName,
                    VolunteerBirthDate = x.Volunteer.DateOfBirth,
                    TransportNeeded = x.TransportNeeded
                }).ToListAsync();

            return schoolVolunteers;
        }

        public async Task<List<GetVolunteersForEventResponse>> GetVolunteersForEvent(int id)
        {
            var availableVolunteersForEvent = await _straniVariDbContext.Volunteers
                .Where(x => !_straniVariDbContext.SchoolVolunteers.Any(y => y.VolunteerId == x.Id && y.EventSchool.EventId == id))
                .Select(v => new GetVolunteersForEventResponse
                {
                    VolunteerId = v.Id,
                    VolunteerAddress = v.Address,
                    VolunteerCity = v.City,
                    FirstName = v.FirstName,
                    LastName = v.LastName,
                    VolunteerBirthDate = v.DateOfBirth, 
                }).ToListAsync(); 

            return availableVolunteersForEvent;
        }

        public async Task<List<GetVolunteersForEventResponse>> GetEventSchoolsVolunteers(int id)
        {
            var volunteerList = await _straniVariDbContext.SchoolVolunteers
                 .Where(x => x.EventSchoolId == id)
                 .Select(v => new GetVolunteersForEventResponse
                 {
                     VolunteerId = v.VolunteerId,
                     VolunteerAddress = v.Volunteer.Address,
                     VolunteerCity = v.Volunteer.City,
                     FirstName = v.Volunteer.FirstName,
                     LastName = v.Volunteer.LastName,
                     IsChecked = true,
                     TransportNeeded = v.TransportNeeded
                 })
                 .ToListAsync();

            var availableVolunteers = await _straniVariDbContext.Volunteers
                .Where(x => !_straniVariDbContext.SchoolVolunteers.Any(y => y.VolunteerId == x.Id && y.EventSchoolId == id))
                .Select(v => new GetVolunteersForEventResponse
                {
                    VolunteerId = v.Id,
                    VolunteerAddress = v.Address,
                    VolunteerCity = v.City,
                    FirstName = v.FirstName,
                    LastName = v.LastName,
                })
                .ToListAsync();

            return volunteerList.Concat(availableVolunteers).ToList();
        }
    }
}
