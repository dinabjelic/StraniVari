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

            for (int i = 1; i <= 2; i++)
            {
                volunteerTrip.Add(new VolunteerTrip
                {
                    Id = i,
                    VolunteerId = random.Next(3, 6), 
                    TripId= 1, 
                    StatusId = 3
                });
            }
            builder.Entity<VolunteerTrip>().HasData(volunteerTrip);
        }
    }
}
