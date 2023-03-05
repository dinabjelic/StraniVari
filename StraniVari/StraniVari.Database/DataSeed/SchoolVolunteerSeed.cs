using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

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
            builder.Entity<SchoolVolunteer>().HasData(schoolVolunteers);
        }
    }
}
