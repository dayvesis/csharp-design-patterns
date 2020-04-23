using NullObjectPattern.Model;
using NullObjectPattern.Services;
using NullObjectPattern.Views;
using System.Collections.Generic;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var carService = new CarService();
            var cars = new List<ICar>();

            cars.Add(carService.GetCar(1));
            cars.Add(carService.GetCar(2));
            cars.Add(carService.GetCar(3));
            cars.Add(carService.GetCar(10));
            cars.Add(carService.GetCar(-10));

            foreach (var car in cars)
            {
                var view = new CarView(car);
                view.RenderView();
            }
        }
    }
}
