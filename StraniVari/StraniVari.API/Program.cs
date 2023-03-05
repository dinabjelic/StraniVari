using StraniVari.API;
using StraniVari.Database;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<StraniVariDbContext>();
    dbContext.Database.EnsureCreated();
}

startup.Configure(app, app.Environment);
app.Run();