using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;

namespace StraniVari.Database.DataSeed
{
    public static class NotificationSeed
    {
        public static void SeedNotifications(this ModelBuilder builder)
        {
            Random random = new Random();

            List<string> meetingTheme = new()
            {
                "Organizacija radionice u sali Prve osnovne skole",
                "Odnos volontera i djece"
            };

            List<string> meetingPlace = new()
            {
                "Ambasada lokalne demokaratije"
            };

            List<string> city = new()
            {
                "Zavidovici"
            };

            List<string> address = new()
            {
                "Roncadelle"
            };

            var startDate = new DateTime(2022, 1, 1);
            var endDate = new DateTime(2022, 11, 29);
            List<Notification> notifications = new();

            for (int i = 1; i <= 5 ; i++)
            {
                notifications.Add(new Notification
                {
                    Id =i,
                    EventId = random.Next(1,5),
                    Address = address[i % 1] ,
                    MeetingTheme = meetingTheme[i % 2],
                    City = city[i % 1],
                    MeetingPlace = meetingPlace[i%1], 
                    MeetingDate = DateGenerator.GenerateRandomDate(startDate, endDate)
                });
            }
            builder.Entity<Notification>().HasData(notifications);
        }
    }
}
