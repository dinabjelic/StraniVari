using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;

namespace StraniVari.Database.DataSeed
{
    public static class TripSeed
    {
        public static void SeedTrips(this ModelBuilder builder)
        {
            Random random = new Random();
            List<Trip> trips = new();

            var startDate6 = new DateTime(2023, 7, 29, 07, 30, 0);
            var endDate6 = new DateTime(2023, 7, 29, 21, 00, 0);
            trips.Add(new Trip
            {
                Id = 1,
                Place = "Sarajevo 2023",
                TripDateTime = DateGenerator.GenerateRandomDate(startDate6, endDate6),
                EventId = 1
            });

            var startDate7 = new DateTime(2022, 7, 29, 07, 30, 0);
            var endDate7 = new DateTime(2022, 7, 29, 21, 00, 0);
            trips.Add(new Trip
            {
                Id = 2,
                Place = "Mostar 2022",
                TripDateTime = DateGenerator.GenerateRandomDate(startDate7, endDate7),
                EventId = 2
            });
            builder.Entity<Trip>().HasData(trips);
        }
    }
}
