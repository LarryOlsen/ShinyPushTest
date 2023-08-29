using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Shiny;

namespace ShinyPushTest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
            .UseShiny()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddTransient<MainPage>();

        builder.Services.AddPushAzureNotificationHubs<MyPushDelegate>(
            Settings.ListenerConnectionString,
            Settings.HubName
        );

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

