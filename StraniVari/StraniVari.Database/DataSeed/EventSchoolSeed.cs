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

            List<EventSchool> eventSchools = new();

            for(int i =1; i<= 10; i++)
            {
                eventSchools.Add(new EventSchool
                {
                    Id =i,
                    EventId = random.Next(1, 5), 
                    NumberOfChildren = numberOfChilder[i%4], 
                    SchoolId = random.Next(1,4)
                });
            }

            eventSchools.Add(new EventSchool
            {
                Id = 11,
                SchoolId=2, 
                EventId=6, 
                NumberOfChildren=50
            });
            //eventSchools = eventSchools.DistinctBy(x => new { x.EventId, x.SchoolId }).ToList();
            builder.Entity<EventSchool>().HasData(eventSchools);
        }
    }
}
