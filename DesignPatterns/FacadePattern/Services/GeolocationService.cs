using System.Collections.Generic;

namespace FacadePattern.Services
{
    public class GeolocationService : IGeolocationService
    {
        private readonly Dictionary<string, string> _cities = new Dictionary<string, string>();

        public GeolocationService()
        {
            _cities.Add("10115", "Berlin");
            _cities.Add("75000", "Paris");
        }

        public string GetCityByPostcode(string postCode)
        {
            if (_cities.TryGetValue(postCode, out string city))
                return city;
            else
                return null;
        }
    }
}
