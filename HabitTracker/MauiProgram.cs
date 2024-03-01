using Microsoft.Extensions.Logging;

namespace HabitTracker
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
                    fonts.AddFont("Manrope-Bold.ttf", "ManropeBold");
                    fonts.AddFont("Manrope-ExtraBold.ttf", "ManropeExtraBold");
                    fonts.AddFont("Manrope-ExtraLight.ttf", "ManropeExtraLight");
                    fonts.AddFont("Manrope-Light.ttf", "ManropeLight");
                    fonts.AddFont("Manrope-Medium.ttf", "ManropeMedium");
                    fonts.AddFont("Manrope-Regular.ttf", "ManropeRegular");
                    fonts.AddFont("Manrope-SemiBold.ttf", "ManropeSemiBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
