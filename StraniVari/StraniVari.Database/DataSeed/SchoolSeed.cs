using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

namespace StraniVari.Database.DataSeed
{
    public static class SchoolSeed
    {
        public static void SeedSchools(this ModelBuilder builder)
        {
            List<string> schoolNames = new()
            {
                "Prva osnovna skola",
                "Druga osnovna skola",
                "Osnovna skola Gostovic",
                "Osnovna skola Poljice"
            };

            List<string> schoolAddrees = new()
            {
                "Safvet-bega Bašagića bb",
                "Sutjeska",
                "Gostovic",
                "Poljice"
            };

            List<string> city = new()
            {
                "Zavidovici"
            };

            List<School> schools = new();

            for (int i = 1; i <= 4; i++)
            {
                schools.Add(new School
                {
                    Id=i, 
                    Name = schoolNames[i % 4],
                    Address = schoolAddrees[i % 4],
                    City = city[i % 1] 
                });
            }
            builder.Entity<School>().HasData(schools);
        }
    }
}
