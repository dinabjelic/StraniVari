using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;

namespace StraniVari.Database.DataSeed
{
    public static class AdministratorSeed
    {
        public static void SeedAdministrators(this ModelBuilder builder) {

            List<string> firsNames = new()
            {
                "Admin",
            };

            List<string> lastNames = new()
            {
                "Admin",
            };

            List<string> address = new()
            {
                "Ulica zlatnih ljiljana",
            };

            List<string> city = new()
            {
                "Zavidovici"
            };

            List<Administrator> administrators = new();

            var startDate = new DateTime(2022, 1, 1);
            var endDate = new DateTime(2022, 11, 29);


            administrators.Add(new Administrator
            {
                    Id = 1,
                    FirstName = firsNames[0],
                    LastName = lastNames[0],
                    Address = address[0],
                    City = city[0],
                    DateOfBirth = DateGenerator.GenerateRandomDate(startDate, endDate),
            });
          
            builder.Entity<Administrator>().HasData(administrators);
        }
    }
}
