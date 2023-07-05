using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

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
           
            List<Notification> notifications = new();

            var startDate1 = new DateTime(2018, 7, 24, 17, 30, 0);
            notifications.Add(new Notification
            {
                Id = 1,
                EventId = 1,
                Address = "Roncadelle",
                MeetingTheme = "Odnos volontera i djece",
                City = "Zavidovici",
                MeetingPlace = "ALD",
                MeetingDate = startDate1
            });

            var startDate2 = new DateTime(2018, 7, 24, 17, 30, 0);
            notifications.Add(new Notification
            {
                Id = 2,
                EventId = 2,
                Address = "Roncadelle",
                MeetingTheme = "Odnos volontera i djece",
                City = "Zavidovici",
                MeetingPlace = "ALD",
                MeetingDate = startDate2
            });


            var startDate3 = new DateTime(2018, 7, 24, 17, 30, 0);
            notifications.Add(new Notification
            {
                Id = 3,
                EventId = 3,
                Address = "Roncadelle",
                MeetingTheme = "Odnos volontera i djece",
                City = "Zavidovici",
                MeetingPlace = "ALD",
                MeetingDate = startDate3
            });

            var startDate4 = new DateTime(2018, 7, 24, 17, 30, 0);
            notifications.Add(new Notification
            {
                Id = 4,
                EventId = 4,
                Address = "Roncadelle",
                MeetingTheme = "Odnos volontera i djece",
                City = "Zavidovici",
                MeetingPlace = "ALD",
                MeetingDate = startDate4
            });


            var startDate5 = new DateTime(2018, 7, 24, 17, 30, 0);
            notifications.Add(new Notification
            {
                Id = 5,
                EventId = 5,
                Address = "Roncadelle",
                MeetingTheme = "Odnos volontera i djece",
                City = "Zavidovici",
                MeetingPlace = "ALD",
                MeetingDate = startDate5
            });

            var startDate6 = new DateTime(2018, 7, 24, 17, 30, 0);
            notifications.Add(new Notification
            {
                Id = 6,
                EventId = 6,
                Address = "Roncadelle",
                MeetingTheme = "Odnos volontera i djece",
                City = "Zavidovici",
                MeetingPlace = "ALD",
                MeetingDate = startDate6
            });
            builder.Entity<Notification>().HasData(notifications);
        }
    }
}
