using Microsoft.EntityFrameworkCore;
using StraniVari.Database;

namespace StraniVari.API.StartupExtensions
{
    public static class StraniVariDbContextExstension
    {
        public static IServiceCollection AddDbContextService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StraniVariDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
