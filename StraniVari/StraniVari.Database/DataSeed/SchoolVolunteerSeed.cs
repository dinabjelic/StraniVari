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

            schoolVolunteers.Add(new SchoolVolunteer
            {
                Id = 1,
                VolunteerId = 2,
                EventSchoolId = 1,
                TransportNeeded = false
            });
            schoolVolunteers.Add(new SchoolVolunteer
            {
                Id = 2,
                VolunteerId = 3,
                EventSchoolId = 2,
                TransportNeeded = false
            });

            schoolVolunteers.Add(new SchoolVolunteer
            {
                Id = 3,
                VolunteerId = 4,
                EventSchoolId = 3,
                TransportNeeded = false
            });
            schoolVolunteers.Add(new SchoolVolunteer
            {
                Id = 4,
                VolunteerId = 5,
                EventSchoolId = 4,
                TransportNeeded = false
            });

            schoolVolunteers.Add(new SchoolVolunteer
            {
                Id = 5,
                VolunteerId = 6,
                EventSchoolId = 5,
                TransportNeeded = false
            });
            schoolVolunteers.Add(new SchoolVolunteer
            {
                Id = 6,
                VolunteerId = 3,
                EventSchoolId = 6,
                TransportNeeded = false
            });


            schoolVolunteers.Add(new SchoolVolunteer
            {
                Id = 7,
                VolunteerId = 4,
                EventSchoolId = 7,
                TransportNeeded = false
            });
            schoolVolunteers.Add(new SchoolVolunteer
            {
                Id = 8,
                VolunteerId = 3,
                EventSchoolId = 8,
                TransportNeeded = false
            });

            schoolVolunteers.Add(new SchoolVolunteer
            {
                Id = 9,
                VolunteerId = 6,
                EventSchoolId = 9,
                TransportNeeded = false
            });
            schoolVolunteers.Add(new SchoolVolunteer
            {
                Id = 10,
                VolunteerId = 3,
                EventSchoolId = 10,
                TransportNeeded = false
            });


            schoolVolunteers.Add(new SchoolVolunteer
            {
                Id = 11,
                VolunteerId = 3,
                EventSchoolId = 11,
                TransportNeeded = false
            });

            builder.Entity<SchoolVolunteer>().HasData(schoolVolunteers);
        }
    }
}
