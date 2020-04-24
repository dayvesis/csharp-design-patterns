using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var carDetailsAdapter = new CarDetailsAdapter(new LegacyCarService());

            Console.WriteLine(carDetailsAdapter.GetCarDetails("Hyundai I30"));
            Console.WriteLine(carDetailsAdapter.GetCarDetails("BMW 318i"));
            Console.WriteLine(carDetailsAdapter.GetCarDetails("Nissan Micra"));
            Console.WriteLine(carDetailsAdapter.GetCarDetails("Volvo V60"));
        }
    }
}
