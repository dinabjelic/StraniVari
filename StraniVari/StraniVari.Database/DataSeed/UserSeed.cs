using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

namespace StraniVari.Database.DataSeed
{
    public static class UserSeed
    {
        public static void SeedUserInformation(this ModelBuilder builder)
        {
            var users = new List<User>()
            {
                new User{
                    Id = 1,
                    FirstName = "admin",
                    LastName = "admin",
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "admin@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEDHUghaTzFVEj+Lu6qgarzl+SR70Q5y3thhQZbT08mdOdsmbYFe2uR+TQBzxk8JZhA==",
                    PhoneNumber = "111",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new User
                {
                    Id = 2,
                    FirstName = "una",
                    LastName = "una",
                    UserName = "una2",
                    NormalizedUserName = "una2",
                    Email = "una2@gmail.com",
                    NormalizedEmail = "user2@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEPh7RPrnb7PqRRIsSyKFo7CJ8nLNnoWeyt8KJGV7EuGIEX0hIXs70+Zuv/hhDwKzVQ==",
                    PhoneNumber = "111",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new User
                {
                    Id = 3,
                    FirstName = "una",
                    LastName = "una",
                    UserName = "una3",
                    NormalizedUserName = "una3",
                    Email = "una3@gmail.com",
                    NormalizedEmail = "user3@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEPh7RPrnb7PqRRIsSyKFo7CJ8nLNnoWeyt8KJGV7EuGIEX0hIXs70+Zuv/hhDwKzVQ==",
                    PhoneNumber = "111",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new User
                {
                    Id = 4,
                    FirstName = "una",
                    LastName = "una",
                    UserName = "una4",
                    NormalizedUserName = "una4",
                    Email = "una4@gmail.com",
                    NormalizedEmail = "user4@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEPh7RPrnb7PqRRIsSyKFo7CJ8nLNnoWeyt8KJGV7EuGIEX0hIXs70+Zuv/hhDwKzVQ==",
                    PhoneNumber = "111",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new User
                {
                    Id = 5,
                    FirstName = "una",
                    LastName = "una",
                    UserName = "una5",
                    NormalizedUserName = "una5",
                    Email = "una5@gmail.com",
                    NormalizedEmail = "user5@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEPh7RPrnb7PqRRIsSyKFo7CJ8nLNnoWeyt8KJGV7EuGIEX0hIXs70+Zuv/hhDwKzVQ==",
                    PhoneNumber = "111",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new User
                {
                    Id = 6,
                    FirstName = "una",
                    LastName = "una",
                    UserName = "una6",
                    NormalizedUserName = "una6",
                    Email = "una6@gmail.com",
                    NormalizedEmail = "user6@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEPh7RPrnb7PqRRIsSyKFo7CJ8nLNnoWeyt8KJGV7EuGIEX0hIXs70+Zuv/hhDwKzVQ==",
                    PhoneNumber = "111",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                }
            };

            builder.Entity<User>().HasData(users);
        }
    }
}
