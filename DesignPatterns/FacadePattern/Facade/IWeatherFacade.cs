using FacadePattern.Model;

namespace FacadePattern.Facade
{
    public interface IWeatherFacade
    {
        Temperature GetTemperatureForPostcode(string postCode, TemperatureUnit unit);
    }
}
