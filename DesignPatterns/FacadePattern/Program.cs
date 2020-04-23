using FacadePattern.Facade;
using FacadePattern.Model;
using System;
using System.Collections.Generic;

namespace FacadePattern
{
    class Program
    {
        private static Random _random = new Random();

        static void Main(string[] args)
        {
            var weatherFacade = new WeatherFacade();
            var units = Enum.GetValues(typeof(TemperatureUnit));
            var desiredUnit = (TemperatureUnit)units.GetValue(_random.Next(units.Length));
            Console.WriteLine($"Desired temperature unit to display: {desiredUnit}");

            var postCodes = new List<string>() { "10115", "75000", "40404" };

            foreach (var postCode in postCodes)
            {
                var temperature = weatherFacade.GetTemperatureForPostcode(postCode, desiredUnit);

                if (temperature != null)
                {
                    Console.WriteLine($"Temperature for location with postcode {postCode} is {temperature}");
                }
                else
                {
                    Console.WriteLine($"Could not find temperature for location with postcode: {postCode}");
                }
            }
        }
    }
}
