
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
    public class EventSchoolService : BaseCrudService<EventSchool, EventSchoolInsertRequest, EventSchoolUpdateRequest, GetSchoolsForEventResponse>, IEventSchoolService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public EventSchoolService(StraniVariDbContext straniVariDbContext, IMapper mapper) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public override async Task Insert(EventSchoolInsertRequest addEventSchoolInsertRequest)
        {
            var eventFound = await _straniVariDbContext.Events.FirstOrDefaultAsync(x => x.Id == addEventSchoolInsertRequest.EventId);

            foreach(var item in addEventSchoolInsertRequest.Schools)
            {
                await _straniVariDbContext.EventSchools.AddAsync(new EventSchool
                {
                    EventId = eventFound.Id,
                    SchoolId = item
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
    }
}
