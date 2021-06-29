using System;
using System.Collections.ObjectModel;
using MauiTemplate.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace MauiTemplate.Pages
{
    public partial class FetchDataPage : ContentPage
    {
        public ObservableCollection<WeatherForecast> Forecasts { get; } = new ObservableCollection<WeatherForecast>();

        readonly WeatherForecastService weatherForecastService;
        public FetchDataPage()
        {
            InitializeComponent();
            weatherForecastService = ServiceProvider.GetService<WeatherForecastService>();
            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            foreach (var forecast in await weatherForecastService.GetForecastAsync(DateTime.Now))
                Forecasts.Add(forecast);
        }
    }
}
