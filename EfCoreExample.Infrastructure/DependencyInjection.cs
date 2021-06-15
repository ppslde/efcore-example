using EfCoreExample.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace EfCoreExample.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContextCodeFirst>(o => 
                o.EnableSensitiveDataLogging()
                    .UseSqlServer(configuration.GetConnectionString("CodeFirst"))
            );

            services.AddDbContext<ApplicationDbContextDbFirst>(o =>
                o.EnableSensitiveDataLogging()
                    .UseSqlServer(configuration.GetConnectionString("DbFirst"))
            );

            return services;
        }
    }
}
