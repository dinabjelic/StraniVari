using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

namespace StraniVari.Database.DataSeed
{
    public static class TripStatusSeed
    {
        public static void SeedStatus(this ModelBuilder builder)
        {
            List<string> status = new()
            {
                "InProgress",
                "Accepted",
                "Declined",
            };

            List<TripStatus> trips = new();

            for (int i = 1; i <= 3; i++)
            {
                trips.Add(new TripStatus
                {
                    Id = i,
                    Status = status[i % 3],
                });
            }
            builder.Entity<TripStatus>().HasData(trips);
        }
    }
}
