using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;

namespace StraniVari.Database.DataSeed
{
    public static class VolunteerSeed
    {
        public static void SeedVolunteers(this ModelBuilder builder)
        {
            List<string> firsNames = new()
            {
                "Una",
                "Edvin",
                "Semina",
                "Ajna",
                "Elda"
            };

            List<string> lastNames = new()
            {
                "Milicevic",
                "Joldic",
                "Sinanovic",
                "Tanovic",
                "Bratanovic"
            };

            List<string> address = new()
            {
                "Ulica zlatnih ljiljana",
                "Ulica 4.manevarskog bataljona"
            };

            List<string> city = new()
            {
                "Zavidovici"
            };

            List<Volunteer> volunteers = new();

            var startDate = new DateTime(2022, 1, 1);
            var endDate = new DateTime(2022, 11, 29);

            for(int i= 1; i<= 5; i++)
            {
                volunteers.Add(new Volunteer
                {
                    Id=i, 
                    FirstName = firsNames[i % 5], 
                    LastName = lastNames[i%5], 
                    Address = address[i%2], 
                    City = city[i%1], 
                    DateOfBirth = DateGenerator.GenerateRandomDate(startDate, endDate), 
                    StartDateOfVolunteering = DateGenerator.GenerateRandomDate(startDate, endDate)
                }); 
            }
            builder.Entity<Volunteer>().HasData(volunteers);
        }
    }
}
