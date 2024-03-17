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
                    fonts.AddFont("BeVietnamPro-Variable.ttf", "BeVietnamPro");
                    fonts.AddFont("Satoshi-Black.ttf", "Satoshi-900");
                    fonts.AddFont("Satoshi-Bold.ttf", "Satoshi-800");
                    fonts.AddFont("Satoshi-Light.ttf", "Satoshi-200");
                    fonts.AddFont("Satoshi-Medium.ttf", "Satoshi-500");
                    fonts.AddFont("Satoshi-Regular.ttf", "Satoshi-400");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
