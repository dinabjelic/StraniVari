using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace StraniVari.Database.DataSeed
{
    public static class RoleSeed
    {
        public static void SeedRoles(this ModelBuilder builder)
        {
            var roles = new List<IdentityRole<int>>()
            {
                new IdentityRole<int>
                {
                    Id=1,
                    Name = "Administrator",
                    ConcurrencyStamp="Administrator",
                    NormalizedName ="Administrator"
                },
                new IdentityRole<int>
                {
                    Id=2,
                    Name = "RegularUser",
                    ConcurrencyStamp="RegularUser",
                    NormalizedName ="RegularUser"
                }
            };

            builder.Entity<IdentityRole<int>>().HasData(roles);
        }
    }
}
