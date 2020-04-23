namespace FacadePattern.Services
{
    public interface IGeolocationService
    {
        string GetCityByPostcode(string postCode);
    }
}
