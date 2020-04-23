using FacadePattern.Model;
using FacadePattern.Services;

namespace FacadePattern.Facade
{
    public class WeatherFacade : IWeatherFacade
    {
        private readonly IGeolocationService _geolocationService;
        private readonly IWeatherForecastService _weatherForecastService;
        private readonly ITemperatureUnitConverter _temperatureUnitConverter;

        public WeatherFacade()
        {
            _geolocationService = new GeolocationService();
            _weatherForecastService = new WeatherForecastService();
            _temperatureUnitConverter = new TemperatureUnitConverter();
        }

        public WeatherFacade(
            IGeolocationService geolocationService,
            IWeatherForecastService weatherForecastService,
            ITemperatureUnitConverter temperatureUnitConverter)
        {
            _geolocationService = geolocationService;
            _weatherForecastService = weatherForecastService;
            _temperatureUnitConverter = temperatureUnitConverter;
        }

        public Temperature GetTemperatureForPostcode(string postCode, TemperatureUnit unit)
        {
            var city = _geolocationService.GetCityByPostcode(postCode);

            if (string.IsNullOrEmpty(city))
                return null;

            var temperature = _weatherForecastService.GetTemperatureForCity(city);

            if (temperature == null)
                return null;

            switch (unit)
            {
                case TemperatureUnit.Celsius:
                    _temperatureUnitConverter.ConvertToCelsius(temperature);
                    break;
                case TemperatureUnit.Fahrenheit:
                    _temperatureUnitConverter.ConvertToFahrenheit(temperature);
                    break;
                default:
                    break;
            }

            return temperature;
        }
    }
}
