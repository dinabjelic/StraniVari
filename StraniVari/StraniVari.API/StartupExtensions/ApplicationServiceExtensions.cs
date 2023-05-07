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
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IPlanAndProgrammeService, PlanAndProgrammeService>();
            services.AddScoped<IEventSchoolService, EventSchoolService>();
            services.AddScoped<ISchoolVolunteerService, SchoolVolunteerService>();
            services.AddScoped<IMaterialSchoolService, MaterialSchoolService>();
            services.AddScoped<ITripService, TripService>();
            services.AddScoped<IVolunteerTripService, VolunteerTripService>();
            services.AddScoped<ITripStatusService, TripStatusService>();

            return services;
        }
    }
}
