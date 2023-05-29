using Microsoft.Extensions.Logging;

namespace ProyectoMaui1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{ PickUp Tacoma = new PickUp("Juan", "Toyota", "Rojo", 2015, "P-123", "PickUp", 200, 0, 100, 5);
		Tacoma.acelerar(100);



		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
