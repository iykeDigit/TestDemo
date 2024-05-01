using FinalAPIDemo.Core;
using FinalAPIDemo.Data;
using Nito.AsyncEx;

namespace FinalAPIDemo
{
    public static class ConfigurationExtensions
    {
        public static void SeedData(this WebApplication app)
        {
            AsyncContext.Run(
                async () =>
                {
                    using (var scope = app.Services.CreateScope())
                    {
                        var dataSeeders = scope.ServiceProvider.GetServices<IDataSeeder>();
                        foreach (var dataSeeder in dataSeeders)
                        {
                            await dataSeeder.SeedDataAsync();
                        }
                    }
                });
        }

        public static void Extensions(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddSqlServer<AppDbContext>(connectionString);
            services.AddScoped<IPlayersService, PlayersService>();
            services.AddScoped<IDataSeeder, DataSeeder>();
        }
    }
}
