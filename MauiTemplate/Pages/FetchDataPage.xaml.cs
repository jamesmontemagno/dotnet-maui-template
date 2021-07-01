using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using MauiTemplate.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace MauiTemplate.Pages
{
    public partial class FetchDataPage : ContentPage
    {        
        public FetchDataPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((FetchDataViewModel)BindingContext).FetchDataCommand.Execute(null);
        }
    }

    public class FetchDataViewModel : BindableObject
    {
        public ObservableCollection<WeatherForecast> Forecasts { get; } = new ObservableCollection<WeatherForecast>();

        readonly WeatherForecastService weatherForecastService;
        public FetchDataViewModel()
        {

            weatherForecastService = ServiceProvider.GetService<WeatherForecastService>();
        }

        ICommand fetchDataCommand;
        public ICommand FetchDataCommand => fetchDataCommand ??= new Command(async() => await FetchData());
        async Task FetchData()
        {
            Forecasts.Clear();
            foreach (var forecast in await weatherForecastService.GetForecastAsync(DateTime.Now))
                Forecasts.Add(forecast);
        }
    }
}