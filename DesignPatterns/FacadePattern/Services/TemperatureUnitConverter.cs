using FacadePattern.Model;

namespace FacadePattern.Services
{
    public class TemperatureUnitConverter : ITemperatureUnitConverter
    {
        public void ConvertToCelsius(Temperature temperature)
        {
            switch (temperature.Unit)
            {
                case TemperatureUnit.Fahrenheit:
                    temperature.Unit = TemperatureUnit.Celsius;
                    temperature.Value = (temperature.Value - 32) / 1.8m;
                    break;
                case TemperatureUnit.Celsius:
                default:
                    break;
            }
        }

        public void ConvertToFahrenheit(Temperature temperature)
        {
            switch (temperature.Unit)
            {
                case TemperatureUnit.Celsius:
                    temperature.Unit = TemperatureUnit.Fahrenheit;
                    temperature.Value = (temperature.Value * 1.8m) + 32;
                    break;
                case TemperatureUnit.Fahrenheit:
                default:
                    break;
            }
        }
    }
}
