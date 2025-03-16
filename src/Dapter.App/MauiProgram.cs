using Dapter.App.ViewModels;
using Dapter.Core;
using Dapter.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Dapter.App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// ViewModels
		builder.Services.AddSingleton<MainPageViewModel>();

		// Views
		builder.Services.AddSingleton<MainPage>();

		// Services
		builder.Services.AddAutoMapper(typeof(AppMappingProfile).Assembly);

		var dbPath = Path.Combine(FileSystem.AppDataDirectory, "dapter.db");
		builder.Services.RegisterDataServices(dbPath);
		builder.Services.RegisterCoreServices();

		ApplyMigrations(builder.Services);

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

    private static void ApplyMigrations(IServiceCollection services)
    {
        using var serviceProvider = services.BuildServiceProvider();
        using var scope = serviceProvider.CreateScope();
        using var dbContext = scope.ServiceProvider.GetRequiredService<DapterDbContext>();

        dbContext.Database.Migrate();
    }
}
