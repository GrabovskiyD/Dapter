using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dapter.Data;

public static class ServicesConfiguration
{
    public static IServiceCollection RegisterDataServices(this IServiceCollection services)
    {
        services.AddDbContext<DapterDbContext>();   

        return services;
    }
}
