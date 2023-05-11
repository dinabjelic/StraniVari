using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;

namespace StraniVari.Database.DataSeed
{
    public static class EventSeed
    {
       public static void SeedEvent(this ModelBuilder builder)
       {
            List<string> eventNames = new()
            {
                "Strani Vari 2018",
                "Strani Vari 2019",
                "Strani Vari 2020",
                "Strani Vari 2021",
                "Strani Vari 2022",
                "Strani Vari 2023",
            };

            List<string> eventTheme = new()
            {
                "Health",
                "Cartoon characters",
                "Favourite activity",
                "Circus",
                "Favourite cartoon",
                "Elements",
            };

            List<Event> events = new();
            var startDate = new DateTime(2019, 7, 27);
            var endDate = new DateTime(2022, 11, 8);

            for(int i =1; i<=5; i++)
            {
                events.Add(new Event
                {
                    Id = i, 
                    Name = eventNames[i % 5] ,
                    StraniVariTheme = eventTheme[i % 5],
                    StartDate = DateGenerator.GenerateRandomDate(startDate, endDate),
                    EndDate = DateGenerator.GenerateRandomDate(startDate, endDate)
                });
            }

            var startDate1 = new DateTime(2023, 7, 27);
            var endDate1 = new DateTime(2023, 11, 8);

            events.Add(new Event
            {
                Id = 6,
                Name = "Strani Vari 2023",
                StraniVariTheme = "Elements",
                StartDate = DateGenerator.GenerateRandomDate(startDate1, endDate1),
                EndDate = DateGenerator.GenerateRandomDate(startDate1, endDate1)
            });

            builder.Entity<Event>().HasData(events);
        }
    }
}
