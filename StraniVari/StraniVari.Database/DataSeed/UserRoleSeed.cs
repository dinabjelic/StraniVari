using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace StraniVari.Database.DataSeed
{
    public static class UserRoleSeed
    {
        public static void SeedUserRoles(this ModelBuilder builder)
        {
            var userRoles = new List<IdentityUserRole<int>>
            {
                new IdentityUserRole<int>
                {
                    UserId = 1,
                    RoleId = 1
                },
                new IdentityUserRole<int>
                {
                    UserId = 1,
                    RoleId = 2
                },
                new IdentityUserRole<int>
                {
                    UserId = 2,
                    RoleId = 2
                },
                new IdentityUserRole<int>
                {
                    UserId = 3,
                    RoleId = 2
                },
                new IdentityUserRole<int>
                {
                    UserId = 4,
                    RoleId = 2
                },
                new IdentityUserRole<int>
                {
                    UserId = 5,
                    RoleId = 2
                },
                new IdentityUserRole<int>
                {
                    UserId = 6,
                    RoleId = 2
                }
            };

            builder.Entity<IdentityUserRole<int>>().HasData(userRoles);
        }
    }
}
