using Contacts_List.Services;
using Microsoft.Extensions.Logging;

namespace Contacts_List
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
            builder.Services.AddTransient<MainPage>(); // Register MainPage as a transient service
            builder.Services.AddSingleton<IDatabaseService, DatabaseService>(); // Register IDatabaseService with its implementation DatabaseService
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
