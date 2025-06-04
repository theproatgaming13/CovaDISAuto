using Microsoft.Extensions.DependencyInjection;
using CovaDISAutoAPI.Domain.Data;
namespace CovaDISAutoAPI.Domain
{
    public static class ServicesConfiguration
    {
        public static void RegisterServices(IServiceCollection services, string connectionString)
        {
            services.AddSqlite<AutoContext>(connectionString);
        }
    }
}
