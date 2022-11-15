using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

namespace StraniVari.Database
{
    public class StraniVariDbContext:IdentityDbContext<User, IdentityRole<int>, int>
    {

        public StraniVariDbContext(DbContextOptions<StraniVariDbContext> options)
         : base(options)
        {
        }
        public DbSet<School> Schools { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}