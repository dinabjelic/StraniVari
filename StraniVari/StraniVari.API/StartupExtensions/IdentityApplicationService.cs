using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using StraniVari.Core.Entities;
using StraniVari.Database;
using System.Text;

namespace StraniVari.API.StartupExtensions
{
    public static class IdentityApplicationService
    {
        public static IServiceCollection AddIdentiyServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddIdentity<User, IdentityRole<int>>()
             .AddEntityFrameworkStores<StraniVariDbContext>().
             AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TokenKey"])),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    
                };
            });
            services.AddAuthorization();

            return services;
        }
    }
}
