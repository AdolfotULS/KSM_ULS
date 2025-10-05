using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using Microcharts.Maui; // ✅ Este sí debe existir en tu versión

namespace KSM_ULS
{
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

            // ✅ Registrar el handler de Microcharts (versión actual)
            builder.UseMicrocharts();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
