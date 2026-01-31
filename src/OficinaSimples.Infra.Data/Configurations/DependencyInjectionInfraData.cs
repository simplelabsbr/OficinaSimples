using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OficinaSimples.Infra.Data.Context;

namespace OficinaSimples.Infra.Data.Configurations
{
    public static class DependencyInjectionInfraData
    {
        public static IServiceCollection AddInfrastructureData(this IServiceCollection services, string appPath)
        {
            var dbPath = Path.Combine(appPath, "oficinasimples.db");

            services.AddPooledDbContextFactory<AppDbContext>(options =>
                options.UseSqlite($"Data Source={dbPath}"));

            return services;
        }
    }
}
