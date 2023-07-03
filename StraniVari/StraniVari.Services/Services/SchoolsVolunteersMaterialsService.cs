using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class SchoolsVolunteersMaterialsService : BaseCrudService<EventSchool, SchoolVolunteerMaterialRequest, SchoolVolunteerMaterialRequest, SchoolVolunteerMaterialRequest>, ISchoolsVolunteersMaterialsService
    {
        private readonly StraniVariDbContext _straniVariDbContext;

        public SchoolsVolunteersMaterialsService(StraniVariDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _straniVariDbContext = dbContext;
        }

        public override async Task Insert(SchoolVolunteerMaterialRequest schoolVolunteerMaterialRequest)
        {
            var eventFound = await _straniVariDbContext.Events.FirstOrDefaultAsync(x => x.Id == schoolVolunteerMaterialRequest.EventId);

            var schoolEvent = new EventSchool
            {
                EventId = eventFound.Id,
                SchoolId = schoolVolunteerMaterialRequest.SchoolId
            };

            await _straniVariDbContext.EventSchools.AddAsync(schoolEvent);
            await _straniVariDbContext.SaveChangesAsync();

            foreach (var item in schoolVolunteerMaterialRequest.Materials)
            {
                await _straniVariDbContext.SchoolMaterials.AddAsync(new SchoolMaterial
                {
                    EventSchoolId = schoolEvent.Id,
                    MaterialId = item
                });
            }

            await _straniVariDbContext.SaveChangesAsync();

            foreach (var item in schoolVolunteerMaterialRequest.Volunteers)
            {
                await _straniVariDbContext.SchoolVolunteers.AddAsync(new SchoolVolunteer
                {
                    EventSchoolId = schoolEvent.Id,
                    VolunteerId = item
                });
            }
            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
