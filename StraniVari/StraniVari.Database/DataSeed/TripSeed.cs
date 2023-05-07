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

            var startDate = new DateTime(2021, 1, 1);
            var endDate = new DateTime(2021, 11, 29);
            List<Trip> trips = new();

            trips.Add(new Trip
            {
                Id = 1,
                Place = tripPlaces[0],
                TripDateTime = DateGenerator.GenerateRandomDate(startDate, endDate),
                EventId = 6
            });
            builder.Entity<Trip>().HasData(trips);
        }
    }
}
