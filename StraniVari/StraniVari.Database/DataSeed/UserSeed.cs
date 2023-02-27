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
                AccessFailedCount = 0
                },
                new User
                {
                Id = 2,
                FirstName = "user",
                LastName = "user",
                UserName = "user",
                NormalizedUserName = "user",
                Email = "user@gmail.com",
                NormalizedEmail = "user@gmail.com",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEPh7RPrnb7PqRRIsSyKFo7CJ8nLNnoWeyt8KJGV7EuGIEX0hIXs70+Zuv/hhDwKzVQ==",
                PhoneNumber = "111",
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = true,
                LockoutEnabled = false,
                AccessFailedCount = 0
                }
            };
            
            builder.Entity<User>().HasData(users);
        }
    }
}
