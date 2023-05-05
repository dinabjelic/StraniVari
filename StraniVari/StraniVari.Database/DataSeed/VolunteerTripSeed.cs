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

            for (int i = 1; i <= 5; i++)
            {
                volunteerTrip.Add(new VolunteerTrip
                {
                    Id = i,
                    VolunteerId = random.Next(2, 6), 
                    TripId= random.Next(1,3), 
                    StatusId = random.Next(1,3)
                });
            }
            builder.Entity<VolunteerTrip>().HasData(volunteerTrip);
        }
    }
}
