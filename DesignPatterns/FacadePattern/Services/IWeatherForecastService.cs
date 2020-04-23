using FacadePattern.Model;

namespace FacadePattern.Services
{
    public interface IWeatherForecastService
    {
        Temperature GetTemperatureForCity(string city);
    }
}
