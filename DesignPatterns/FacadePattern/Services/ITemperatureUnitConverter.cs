using FacadePattern.Model;

namespace FacadePattern.Services
{
    public interface ITemperatureUnitConverter
    {
        void ConvertToCelsius(Temperature temperature);
        void ConvertToFahrenheit(Temperature temperature);
    }
}
