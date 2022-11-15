using StraniVari.Services.Interfaces;
using StraniVari.Services.Services;

namespace StraniVari.API.StartupExtensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ISchoolService, SchoolService>();
            services.AddScoped<IEventService, EventService>();

            return services;
        }
    }
}
