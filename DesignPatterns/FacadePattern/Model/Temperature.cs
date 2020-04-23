namespace FacadePattern.Model
{
    public class Temperature
    {
        public decimal Value { get; set; }
        public TemperatureUnit Unit { get; set; }

        public override string ToString()
        {
            var unitSuffix = Unit switch
            {
                TemperatureUnit.Celsius => "C",
                TemperatureUnit.Fahrenheit => "F",
                _ => string.Empty
            };

            return $"{Value}{unitSuffix}";
        }
    }
}
