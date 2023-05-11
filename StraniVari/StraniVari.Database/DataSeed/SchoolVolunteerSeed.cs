using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;

namespace StraniVari.Database.DataSeed
{
    public static class SchoolVolunteerSeed
    {
        public static void SeedSchoolVolunteers(this ModelBuilder builder)
        {
            Random random = new Random();

            List<bool> transportNeeded = new()
            {
                true,
                false
            };

            List<SchoolVolunteer> schoolVolunteers = new();

            for (int i = 1; i <= 5; i++)
            {
                schoolVolunteers.Add(new SchoolVolunteer
                {
                    Id=i, 
                    TransportNeeded = transportNeeded[i % 2],
                    EventSchoolId = random.Next(1, 10),
                    VolunteerId = random.Next(2, 6)
                });
            }

            schoolVolunteers.Add(new SchoolVolunteer
            {
                Id = 6,
                VolunteerId=2, 
                EventSchoolId=11, 
                TransportNeeded= false
            });

            builder.Entity<SchoolVolunteer>().HasData(schoolVolunteers);
        }
    }
}
