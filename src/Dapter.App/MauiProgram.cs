using Dapter.Data;
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

		var dbPath = Path.Combine(FileSystem.AppDataDirectory, "dapter.db");

		builder.Services
			.RegisterDataServices(dbPath);

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
