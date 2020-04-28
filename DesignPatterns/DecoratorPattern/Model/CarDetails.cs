namespace DecoratorPattern.Model
{
    public class CarDetails : ICarDetails
    {
        public string Model { get; set; }
        public int Horsepower { get; set; }
        public string Type { get; set; }
        public decimal Consumption { get; set; }
        
        public CarDetails(string model, int horsepower, string type, decimal consumption)
        {
            Model = model;
            Horsepower = horsepower;
            Type = type;
            Consumption = consumption;
        }

        public void PrintDetails()
        {
            System.Console.WriteLine($"[{Model}] Power: {Horsepower}HP, Type: {Type}, Avg. fuel consumption: {Consumption} l/100km");
        }
    }
}
