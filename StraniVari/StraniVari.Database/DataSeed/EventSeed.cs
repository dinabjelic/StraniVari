using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

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

            var startDate1 = new DateTime(2018, 7, 24);
            var endDate1 = new DateTime(2018, 8, 6);

            events.Add(new Event
            {
                Id = 6,
                Name = "Strani Vari 2018",
                StraniVariTheme = "Favourite activity",
                StartDate = startDate1,
                EndDate = endDate1
            });

            var startDate2 = new DateTime(2019, 7, 24);
            var endDate2 = new DateTime(2019, 8, 6);

            events.Add(new Event
            {
                Id = 5,
                Name = "Strani Vari 2019",
                StraniVariTheme = "Health",
                StartDate = startDate2,
                EndDate = endDate2
            });

            var startDate3 = new DateTime(2020, 7, 24);
            var endDate3 = new DateTime(2020, 8, 6);

            events.Add(new Event
            {
                Id = 4,
                Name = "Strani Vari 2020",
                StraniVariTheme = "Cartoon characters",
                StartDate = startDate3,
                EndDate = endDate3
            });

            var startDate4 = new DateTime(2021, 7, 24);
            var endDate4 = new DateTime(2021, 8, 6);

            events.Add(new Event
            {
                Id = 3,
                Name = "Strani Vari 2021",
                StraniVariTheme = "Circus",
                StartDate = startDate4,
                EndDate = endDate4
            });


            var startDate5 = new DateTime(2022, 7, 24);
            var endDate5 = new DateTime(2022, 8, 6);

            events.Add(new Event
            {
                Id = 2,
                Name = "Strani Vari 2022",
                StraniVariTheme = "Favourite cartoon",
                StartDate = startDate5,
                EndDate = endDate5
            });

            var startDate6 = new DateTime(2023, 7, 24);
            var endDate6 = new DateTime(2023, 8, 6);
            events.Add(new Event
            {
                Id = 1,
                Name = "Strani Vari 2023",
                StraniVariTheme = "Elements",
                StartDate = startDate6,
                EndDate = endDate6
            });

            builder.Entity<Event>().HasData(events);
        }
    }
}
