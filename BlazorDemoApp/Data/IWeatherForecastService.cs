using System;
using System.Threading.Tasks;

namespace BlazorDemoApp.Data
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}