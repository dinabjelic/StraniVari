using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class EventSchoolService : BaseCrudService<EventSchool, SchoolVolunteerMaterialRequest, SchoolVolunteerMaterialRequest, GetSchoolsForEventResponse>, IEventSchoolService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public EventSchoolService(StraniVariDbContext straniVariDbContext, IMapper mapper) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public override async Task Insert(SchoolVolunteerMaterialRequest schoolVolunteerMaterialRequest)
        {
            var eventFound = await _straniVariDbContext.Events.FirstOrDefaultAsync(x => x.Id == schoolVolunteerMaterialRequest.EventId);

            var schoolEvent = new EventSchool
            {
                EventId = eventFound.Id,
                SchoolId = schoolVolunteerMaterialRequest.SchoolId,
                NumberOfChildren = schoolVolunteerMaterialRequest.NumberOfChildren
            };

            await _straniVariDbContext.EventSchools.AddAsync(schoolEvent);
            await _straniVariDbContext.SaveChangesAsync();

            foreach (var item in schoolVolunteerMaterialRequest.Material)
            {
                await _straniVariDbContext.SchoolMaterials.AddAsync(new SchoolMaterial
                {
                    EventSchoolId = schoolEvent.Id,
                    MaterialId = item.Id,
                    Quantity = item.NumberOfMaterial
                });
            }
            await _straniVariDbContext.SaveChangesAsync();

            foreach (var item in schoolVolunteerMaterialRequest.Volunteers)
            {
                await _straniVariDbContext.SchoolVolunteers.AddAsync(new SchoolVolunteer
                {
                    EventSchoolId = schoolEvent.Id,
                    VolunteerId = item.VolunteerId,
                    TransportNeeded = item.TransportNeeded
                });
            }
            await _straniVariDbContext.SaveChangesAsync();
        }

        public override async Task Update(int id, SchoolVolunteerMaterialRequest schoolVolunteerMaterialRequest)
        {
            var schoolsForEvent = await _straniVariDbContext.EventSchools.FirstOrDefaultAsync(x => x.Id == id);
             _straniVariDbContext.EventSchools.Remove(schoolsForEvent);
            _straniVariDbContext.SaveChanges();


            var materialForEvent = await _straniVariDbContext.SchoolMaterials.Where(x => x.EventSchoolId == id).ToListAsync();
            _straniVariDbContext.SchoolMaterials.RemoveRange(materialForEvent);
            _straniVariDbContext.SaveChanges();

            var volunteersForEvent = await _straniVariDbContext.SchoolVolunteers.Where(x => x.EventSchoolId == id).ToListAsync();
            _straniVariDbContext.SchoolVolunteers.RemoveRange(volunteersForEvent);
            _straniVariDbContext.SaveChanges();


            var eventFound = await _straniVariDbContext.Events.FirstOrDefaultAsync(x => x.Id == schoolVolunteerMaterialRequest.EventId);
            var schoolEvent = new EventSchool
            {
                EventId = eventFound.Id,
                SchoolId = schoolVolunteerMaterialRequest.SchoolId,
                NumberOfChildren = schoolVolunteerMaterialRequest.NumberOfChildren
            };

            await _straniVariDbContext.EventSchools.AddAsync(schoolEvent);
            await _straniVariDbContext.SaveChangesAsync();

            foreach (var item in schoolVolunteerMaterialRequest.Material)
            {
                await _straniVariDbContext.SchoolMaterials.AddAsync(new SchoolMaterial
                {
                    EventSchoolId = schoolEvent.Id,
                    MaterialId = item.Id,
                    Quantity = item.NumberOfMaterial
                });
            }
            await _straniVariDbContext.SaveChangesAsync();

            foreach (var item in schoolVolunteerMaterialRequest.Volunteers)
            {
                await _straniVariDbContext.SchoolVolunteers.AddAsync(new SchoolVolunteer
                {
                    EventSchoolId = schoolEvent.Id,
                    VolunteerId = item.VolunteerId,
                    TransportNeeded = item.TransportNeeded
                });
            }
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetSchoolsForEventResponse>> GetSchoolsForEvent(int id)
        {
            var schoolForEvent = await _straniVariDbContext.EventSchools
                .Include(x => x.Event)
                .Where(x => x.EventId == id)
                .Select(x => new GetSchoolsForEventResponse
                {
                    EventId = x.EventId,
                    SchoolEventId = x.Id,
                    SchoolId = x.SchoolId,
                    NumberOfChildren = x.NumberOfChildren,
                    SchoolAddress = x.School.Name,
                    SchoolCity = x.School.City,
                    SchoolName = x.School.Name
                }).ToListAsync();

            return schoolForEvent;
        }

        public async Task<List<GetAvailableSchoolsForEventResponse>> GetAvailableSchools(int id)
        {
            var availableSchoolsForEvent = await _straniVariDbContext.Schools
                .Where(x => !_straniVariDbContext.EventSchools.Any(y => y.SchoolId == x.Id && y.EventId == id))
                .Select(e => new GetAvailableSchoolsForEventResponse
                {
                    SchoolEventId = id,
                    SchoolId = e.Id,
                    SchoolAddress = e.Address,
                    SchoolCity = e.City,
                    SchoolName = e.Name
                }).ToListAsync();

            return availableSchoolsForEvent;
        }
    }
}
