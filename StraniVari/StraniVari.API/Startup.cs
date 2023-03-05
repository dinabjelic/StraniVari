using StraniVari.API.StartupExtensions;

namespace StraniVari.API
{

    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IServiceCollection ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();


            services.AddApplicationServices(_configuration);
            services.AddIdentiyServices(_configuration);
            services.AddDbContextService(_configuration);
            services.AddSwaggerService();

            //services.AddDbContext<StraniVariDbContext>(options =>
            //   options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));


            return services;
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            app.UseSwagger();
            app.UseSwaggerUI();

            
            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();
            app.UseEndpoints(x =>
            {
                x.MapControllers();
            });
        }
    }
}
