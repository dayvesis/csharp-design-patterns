namespace AdapterPattern
{
    public class LegacyCarService : ILegacyCarService
    {
        public decimal GetAverageConsumption(string model) =>
            model switch
            {
                "Hyundai I30" => 6.0m,
                "BMW 318i" => 6.2m,
                "Nissan Micra" => 5.8m,
                _ => 0.0m
            };

        public int GetHorsePower(string model) =>
            model switch
            {
                "Hyundai I30" => 75,
                "BMW 318i" => 136,
                "Nissan Micra" => 65,
                _ => 0
            };

        public int GetTopSpeed(string model) =>
            model switch
            {
                "Hyundai I30" => 175,
                "BMW 318i" => 195,
                "Nissan Micra" => 170,
                _ => 0
            };
}
}
