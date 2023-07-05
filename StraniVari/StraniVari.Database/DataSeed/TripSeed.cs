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
            List<string> tripPlaces = new()
            {
                "Sarajevo",
            };
            List<Trip> trips = new();

            var startDate6 = new DateTime(2023, 7, 29, 07, 30, 0);
            var endDate6 = new DateTime(2023, 7, 29, 21, 00, 0);
            trips.Add(new Trip
            {
                Id = 1,
                Place = tripPlaces[0],
                TripDateTime = DateGenerator.GenerateRandomDate(startDate6, endDate6),
                EventId = 6
            });
            builder.Entity<Trip>().HasData(trips);
        }
    }
}
