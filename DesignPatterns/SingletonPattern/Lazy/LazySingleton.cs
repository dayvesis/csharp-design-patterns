using System;

namespace SingletonPattern.Lazy
{
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        public int Value { get; set; }

        public static LazySingleton Instance
        {
            get
            {
                Console.WriteLine("Lazy singleton instance called");
                return _instance.Value;
            }
        }

        public void PrintValue()
        {
            Console.WriteLine($"Value of Lazy Singleton: {Value}");
        }
    }
}
