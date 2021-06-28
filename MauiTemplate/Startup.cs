using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MauiTemplate.Data;

namespace MauiTemplate
{
    public class Startup : IStartup
    {
        public void Configure(IAppHostBuilder appBuilder)
        {
            appBuilder
                .UseMauiApp<App>()
                .ConfigureServices(ConfigureServices)
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("ionicons.ttf", "IonIcons");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
        }

        void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();
        }
    }
}