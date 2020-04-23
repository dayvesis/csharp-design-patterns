using NullObjectPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObjectPattern.Services
{
    public class CarService
    {
        private CarRepository _carsRepo = new CarRepository();

        public ICar GetCar(int id) => _carsRepo.GetCar(id);

        public class CarRepository
        {
            private IList<Car> _cars = new List<Car>();

            public CarRepository()
            {
                _cars.Add(new Car(1, "Bravo", "Fiat"));
                _cars.Add(new Car(2, "I30", "Hyundai"));
                _cars.Add(new Car(3, "Stinger", "Kia"));
            }

            public ICar GetCar(int id)
            {
                bool carExists = _cars.Any(c => c.Id == id);

                if (carExists)
                    return _cars.First(c => c.Id == id);
                else
                    return new NullCar();
            }
        }
    }
}
