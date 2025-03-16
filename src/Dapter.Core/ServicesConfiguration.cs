using Dapter.Core.Abstractions.Services;
using Dapter.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Dapter.Core;

public static class ServicesConfiguration
{
    public static IServiceCollection RegisterCoreServices(IServiceCollection services)
    {
        services.AddScoped<ILifeAspectService, LifeAspectService>();

        return services;
    }
}
