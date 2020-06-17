using Microsoft.Extensions.DependencyInjection;
using SingletonPattern.IoC;
using SingletonPattern.Lazy;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton implementation using Lazy<T>:
            // This should only return one instance, not three different.
            var instance1 = LazySingleton.Instance;
            var instance2 = LazySingleton.Instance;
            var instance3 = LazySingleton.Instance;

            instance1.Value = 3;
            instance2.Value = 5;
            instance3.Value = 10;

            // All values should be equal to 10 because in fact theres only one instance of Singleton, not three
            instance1.PrintValue();
            instance2.PrintValue();
            instance3.PrintValue();

            // Singleton implementation using IoC/DI:
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ISingleton, Singleton>()
                .BuildServiceProvider();

            var instance4 = serviceProvider.GetService<ISingleton>() as Singleton;
            var instance5 = serviceProvider.GetService<ISingleton>() as Singleton;
            var instance6 = serviceProvider.GetService<ISingleton>() as Singleton;

            // All values should be equal to 13 because theres only one instance of Singleton registered via DI
            instance4.Value = 6;
            instance5.Value = 10;
            instance6.Value = 13;

            instance4.PrintValue();
            instance5.PrintValue();
            instance6.PrintValue();
        }
    }
}
