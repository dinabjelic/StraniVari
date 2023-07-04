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
            await using var transaction = await _straniVariDbContext.Database.BeginTransactionAsync();
            try
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

                await _straniVariDbContext.SchoolMaterials.AddRangeAsync(schoolVolunteerMaterialRequest.Material.Select(item => new SchoolMaterial
                {
                    EventSchoolId = schoolEvent.Id,
                    MaterialId = item.Id,
                    Quantity = item.NumberOfMaterial
                }));

                await _straniVariDbContext.SchoolVolunteers.AddRangeAsync(schoolVolunteerMaterialRequest.Volunteers.Select(item => new SchoolVolunteer
                {
                    EventSchoolId = schoolEvent.Id,
                    VolunteerId = item.VolunteerId,
                    TransportNeeded = item.TransportNeeded
                }));

                await _straniVariDbContext.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public override async Task Update(int id, SchoolVolunteerMaterialRequest schoolVolunteerMaterialRequest)
        {
            await using var transaction = await _straniVariDbContext.Database.BeginTransactionAsync();
            try
            {
                EventSchool? eventSchool = await _straniVariDbContext.EventSchools.FindAsync(id);

                eventSchool!.NumberOfChildren = schoolVolunteerMaterialRequest.NumberOfChildren;

                var materialForEvent = await _straniVariDbContext
                    .SchoolMaterials
                    .Where(x => x.EventSchoolId == id)
                    .ToListAsync();

                _straniVariDbContext.SchoolMaterials.RemoveRange(materialForEvent);

                var volunteersForEvent = await _straniVariDbContext
                    .SchoolVolunteers
                    .Where(x => x.EventSchoolId == id)
                    .ToListAsync();

                _straniVariDbContext.SchoolVolunteers.RemoveRange(volunteersForEvent);

                await _straniVariDbContext.SaveChangesAsync();


                await _straniVariDbContext.SchoolMaterials.AddRangeAsync(schoolVolunteerMaterialRequest.Material.Select(
                    item => new SchoolMaterial
                    {
                        EventSchoolId = eventSchool.Id,
                        MaterialId = item.Id,
                        Quantity = item.NumberOfMaterial
                    }));


                await _straniVariDbContext.SchoolVolunteers.AddRangeAsync(schoolVolunteerMaterialRequest.Volunteers.Select(item => new SchoolVolunteer
                {
                    EventSchoolId = eventSchool.Id,
                    VolunteerId = item.VolunteerId,
                    TransportNeeded = item.TransportNeeded
                }));

                await _straniVariDbContext.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
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
