using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

namespace StraniVari.Database.DataSeed
{
    public static class VolunteerTripSeed
    {
        public static void SeedVolunteerTrips(this ModelBuilder builder)
        {
            Random random = new Random();
            List<VolunteerTrip> volunteerTrip = new();

            //volunteerTrip.Add(new VolunteerTrip
            //{
            //    Id = 1,
            //    VolunteerId = 2,
            //    TripId = 1,
            //    StatusId = 1
            //});
            volunteerTrip.Add(new VolunteerTrip
            {
                Id = 2,
                VolunteerId = 3,
                TripId = 2,
                StatusId = 1
            });
            volunteerTrip.Add(new VolunteerTrip
            {
                Id = 3,
                VolunteerId = 4,
                TripId = 2,
                StatusId = 1
            });


            builder.Entity<VolunteerTrip>().HasData(volunteerTrip);
        }
    }
}
