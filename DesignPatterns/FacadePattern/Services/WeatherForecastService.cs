using FacadePattern.Model;
using System.Collections.Generic;

namespace FacadePattern.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly Dictionary<string, Temperature> _temperatures = new Dictionary<string, Temperature>();

        public WeatherForecastService()
        {
            _temperatures.Add("Berlin", new Temperature() { Unit = TemperatureUnit.Celsius, Value = 23.4m });
            _temperatures.Add("Paris", new Temperature() { Unit = TemperatureUnit.Celsius, Value = 15.0m });
        }

        public Temperature GetTemperatureForCity(string city)
        {
            if (_temperatures.TryGetValue(city, out Temperature temperature))
                return temperature;
            else
                return null;
        }
    }
}
