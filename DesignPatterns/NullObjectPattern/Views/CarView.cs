using NullObjectPattern.Model;
using System;

namespace NullObjectPattern.Views
{
    public class CarView
    {
        private ICar _car;

        public CarView(ICar car)
        {
            _car = car;
        }

        public void RenderView()
        {
            Console.WriteLine(_car.Id);
            Console.WriteLine(_car.Model);
            Console.WriteLine(_car.Manufacturer);
        }
    }
}
