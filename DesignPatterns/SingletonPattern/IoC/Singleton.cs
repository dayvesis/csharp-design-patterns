using System;

namespace SingletonPattern.IoC
{
    public class Singleton : ISingleton
    {
        public int Value { get; set; }

        public void PrintValue()
        {
            Console.WriteLine($"Value from IoC Singleton: {Value}");
        }
    }
}
