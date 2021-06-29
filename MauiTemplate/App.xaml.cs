using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using System;
using Application = Microsoft.Maui.Controls.Application;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;

namespace MauiTemplate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override IWindow CreateWindow(IActivationState activationState)
        {
            this.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>()
                .SetImageDirectory("Assets");

            return new Microsoft.Maui.Controls.Window(new AppShell());
        }
    }

    public static class ServiceProvider
    {
        public static TService GetService<TService>()
            => Current.GetService<TService>();

        public static IServiceProvider Current
            =>
#if WINDOWS10_0_17763_0_OR_GREATER
			MauiWinUIApplication.Current.Services;
#elif ANDROID
			MauiApplication.Current.Services;
#elif IOS || MACCATALYST
            MauiUIApplicationDelegate.Current.Services;
#else
			null;
#endif
    }
}
