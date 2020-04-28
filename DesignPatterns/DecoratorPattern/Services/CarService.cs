using DecoratorPattern.Model;
using System;

namespace DecoratorPattern.Services
{
    public class CarService : ICarService
    {
        public CarDetails GetCarDetails(string model) =>
            model switch
            {
                "BMW 318i" => new CarDetails("BMW 318i", 156, "Sedan", 6.7m),
                "Hyundai I30" => new CarDetails("Hyundai I30", 85, "Hatchback", 6.6m),
                "Nissan Micra" => new CarDetails("Nissan Micra", 65, "Hatchback", 6.0m),
                _ => throw new Exception($"Car {model} not found")
            };
    }
}
