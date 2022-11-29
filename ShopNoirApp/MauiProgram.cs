using CommunityToolkit.Maui;

namespace ShopNoirApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
             .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                fonts.AddFont("Montserrat-Regular.ttf", "SerratRegular");
                fonts.AddFont("Montserrat-Bold.ttf", "SerratBold");
            });

		return builder.Build();
	}
}
