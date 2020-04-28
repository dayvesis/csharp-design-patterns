using DecoratorPattern.Decorators;
using DecoratorPattern.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;
using System.Linq;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logging setup:
            var configureNamedOptions = new ConfigureNamedOptions<ConsoleLoggerOptions>("", null);
            var optionsFactory = new OptionsFactory<ConsoleLoggerOptions>(new[] { configureNamedOptions }, Enumerable.Empty<IPostConfigureOptions<ConsoleLoggerOptions>>());
            var optionsMonitor = new OptionsMonitor<ConsoleLoggerOptions>(optionsFactory, Enumerable.Empty<IOptionsChangeTokenSource<ConsoleLoggerOptions>>(), new OptionsCache<ConsoleLoggerOptions>());
            var loggerFactory = new LoggerFactory(new[] { new ConsoleLoggerProvider(optionsMonitor) }, new LoggerFilterOptions { MinLevel = LogLevel.Information });
            var logger = loggerFactory.CreateLogger<CarServiceLoggingDecorator>();

            var carService = new CarServiceLoggingDecorator(new CarService(), logger);
            var carDetails1 = carService.GetCarDetails("Hyundai I30");
            var carDetails2 = carService.GetCarDetails("BMW 318i");

            carDetails1.PrintDetails();
            carDetails2.PrintDetails();
        }
    }
}
