using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class SchoolVolunteerService : IBase_CrudService<SchoolVolunteer, InsertVolunteerToSchoolRequest, UpdateVolunteerAssignedToSchoolRequest, GetVolunteersForSchoolResponse>, ISchoolVolunteerService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public SchoolVolunteerService(StraniVariDbContext straniVariDbContext, IMapper mapper) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task Insert(InsertVolunteerToSchoolRequest insertVolunteerToSchoolRequest)
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

        public async Task<List<GetVolunteersForSchoolResponse>> GetById(int id)
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
    }
}
