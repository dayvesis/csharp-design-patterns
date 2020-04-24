namespace AdapterPattern
{
    public class CarDetails
    {
        public string Model { get; set; }
        public decimal Consumption { get; set; }
        public int Power { get; set; }
        public int TopSpeed { get; set; }

        public override string ToString()
        {
            return $"[{Model}] Avg. Consumption: {Consumption}, Power: {Power}, Top speed: {TopSpeed}";
        }
    }
}
