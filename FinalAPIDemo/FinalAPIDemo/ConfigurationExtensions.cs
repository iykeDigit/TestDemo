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
    }
}
