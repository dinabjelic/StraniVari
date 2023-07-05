using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

namespace StraniVari.Database.DataSeed
{
    public static class EventSchoolSeed
    {
        public static void SeedEventSchool(this ModelBuilder builder)
        {
            Random random = new Random();
            List<int> numberOfChilder = new()
            {
                123, 
                90, 
                80,
                50, 
            };
           

            List<EventSchool> eventSchools = new List<EventSchool>();
            eventSchools.Add(new EventSchool
            {
                Id = 1,
                SchoolId = 2,
                EventId = 1,
                NumberOfChildren = 50
            });
            eventSchools.Add(new EventSchool
            {
                Id = 2,
                SchoolId = 1,
                EventId = 1,
                NumberOfChildren = 70
            });

            eventSchools.Add(new EventSchool
            {
                Id = 3,
                SchoolId = 2,
                EventId = 2,
                NumberOfChildren = 50
            });
            eventSchools.Add(new EventSchool
            {
                Id = 4,
                SchoolId = 1,
                EventId = 2,
                NumberOfChildren = 70
            });

            eventSchools.Add(new EventSchool
            {
                Id = 5,
                SchoolId = 2,
                EventId = 3,
                NumberOfChildren = 50
            });
            eventSchools.Add(new EventSchool
            {
                Id = 6,
                SchoolId = 1,
                EventId = 3,
                NumberOfChildren = 70
            });


            eventSchools.Add(new EventSchool
            {
                Id = 7,
                SchoolId = 2,
                EventId = 4,
                NumberOfChildren = 50
            });
            eventSchools.Add(new EventSchool
            {
                Id = 8,
                SchoolId = 1,
                EventId = 4,
                NumberOfChildren = 70
            });

            eventSchools.Add(new EventSchool
            {
                Id = 9,
                SchoolId = 2,
                EventId = 5,
                NumberOfChildren = 50
            });
            eventSchools.Add(new EventSchool
            {
                Id = 10,
                SchoolId = 1,
                EventId = 5,
                NumberOfChildren = 70
            });

            eventSchools.Add(new EventSchool
            {
                Id = 11,
                SchoolId=2, 
                EventId=6, 
                NumberOfChildren=50
            });
            eventSchools.Add(new EventSchool
            {
                Id = 12,
                SchoolId = 1,
                EventId = 6,
                NumberOfChildren = 70
            });
            builder.Entity<EventSchool>().HasData(eventSchools);
        }
    }
}
