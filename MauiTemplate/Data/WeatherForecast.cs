using System;
using Microsoft.Maui.Essentials;

namespace MauiTemplate.Data
{
    public record WeatherForecast(DateTime Date, int TemperatureC, string Summary)
    {
        public int TemperatureF => (int)UnitConverters.CelsiusToFahrenheit(TemperatureC);

    }
}
