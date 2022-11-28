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
            services.AddScoped<IVolunteerService, VolunteerService>();
            services.AddScoped<IVolunteerSchoolService, VolunteerSchoolService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IMaterialSchoolService, MaterialSchoolService>();
            services.AddScoped<IStraniVariThemeService, StraniVariThemeService>();
            services.AddScoped<IMeetingService, MeetingService>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IPlanAndProgrammeService, PlanAndProgrammeService>();

            return services;
        }
    }
}
