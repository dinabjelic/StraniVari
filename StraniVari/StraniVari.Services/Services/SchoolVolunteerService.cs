﻿using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class SchoolVolunteerService: ISchoolVolunteerService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public SchoolVolunteerService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task AddVolunteerToSchoolAsync(InsertVolunteerToSchoolRequest insertVolunteerToSchoolRequest)
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

        public async Task DeleteVolunteerFromSchoolAsync(int id)
        {
            var volunteerFound = await _straniVariDbContext.SchoolVolunteers.FirstOrDefaultAsync(x => x.Id == id);

            if (volunteerFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _straniVariDbContext.SchoolVolunteers.Remove(volunteerFound);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetVolunteersForSchoolResponse>> SchoolVolunteerListAsync(int id)
        {
            var schoolVolunteers = await _straniVariDbContext.SchoolVolunteers
                .Include(x => x.EventSchool)
                .Where(x=>x.EventSchoolId == id)
                .Select(x => new GetVolunteersForSchoolResponse
                {
                    VolunteerId = x.VolunteerId, 
                    SchoolVolunteerId = x.Id, 
                    VolunteerAddress = x.Volunteer.Address,
                    VolunteerCity = x.Volunteer.City,
                    FirstName = x.Volunteer.FirstName,
                    LastName = x.Volunteer.LastName,
                    //EventName = x.EventSchool.Event.Name,
                    //EndDate = x.EventSchool.Event.EndDate,
                    //StartDate = x.EventSchool.Event.StartDate,
                    //SchoolAddress = x.EventSchool.School.Address,
                    //SchoolCity = x.EventSchool.School.City,
                    //SchoolName = x.EventSchool.School.Name,
                    //StraniVariTheme = x.EventSchool.Event.StraniVariTheme,
                    TransportNeeded = x.TransportNeeded
                }).ToListAsync();

            return schoolVolunteers;
        }

        public async Task UpdateVolunteerDetailsAsync(UpdateVolunteerAssignedToSchoolRequest updateVolunteerAssignedToSchoolRequest)
        {
            if (updateVolunteerAssignedToSchoolRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var volunteerSchoolFound = await _straniVariDbContext.SchoolVolunteers.FirstOrDefaultAsync(x => x.Id == updateVolunteerAssignedToSchoolRequest.SchoolVolunteerId);

            if (volunteerSchoolFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            volunteerSchoolFound.TransportNeeded = updateVolunteerAssignedToSchoolRequest.TransportNeeded;

            _straniVariDbContext.SchoolVolunteers.Update(volunteerSchoolFound);
            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}