using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;

namespace StraniVari.Database.DataSeed
{
    public static class TripSeed
    {
        public static void SeedTrips(this ModelBuilder builder)
        {
            List<string> tripPlaces = new()
            {
                "Sarajevo",
                "Mostar",
                "Tuzla",
            };

            var startDate = new DateTime(2021, 1, 1);
            var endDate = new DateTime(2021, 11, 29);
            List<Trip> trips = new();

            for (int i = 1; i <= 3; i++)
            {
                trips.Add(new Trip
                {
                    Id = i,
                    Place = tripPlaces[i % 3],
                    TripDateTime = DateGenerator.GenerateRandomDate(startDate, endDate),
                });
            }
            builder.Entity<Trip>().HasData(trips);
        }
    }
}
