using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Infrastracture;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices
        (this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database");
        
        //// Add services to the container.
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.AddInterceptors(new AuditableEntityInterceptor());
            options.UseSqlServer(connectionString);
        });
            
        
        return services;
    }
}