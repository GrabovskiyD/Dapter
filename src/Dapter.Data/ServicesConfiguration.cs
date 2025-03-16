using Dapter.Core.Abstractions.Repositories;
using Dapter.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dapter.Data;

public static class ServicesConfiguration
{
    public static IServiceCollection RegisterDataServices(this IServiceCollection services, string? dbPath)
    {
        ArgumentNullException.ThrowIfNull(dbPath);

        services.AddDbContext<DapterDbContext>(builder =>
        {
            builder.UseSqlite($"Filename={dbPath}", options =>
            {
                options.MigrationsAssembly(typeof(DapterDbContext).Assembly.FullName);
                options.MigrationsHistoryTable(DapterDbContext.MigrationsHistoryTableName);
            });
        });

        services.AddAutoMapper(typeof(DataMappingProfile).Assembly);
        services.AddScoped<ILifeAspectRepository, LifeAspectRepository>();

        return services;
    }
}
