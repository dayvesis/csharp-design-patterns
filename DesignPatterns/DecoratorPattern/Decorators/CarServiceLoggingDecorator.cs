using DecoratorPattern.Model;
using DecoratorPattern.Services;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DecoratorPattern.Decorators
{
    public class CarServiceLoggingDecorator : ICarService
    {
        private ICarService _carService;
        private ILogger<CarServiceLoggingDecorator> _logger;

        public CarServiceLoggingDecorator(ICarService carService, ILogger<CarServiceLoggingDecorator> logger)
        {
            _carService = carService;
            _logger = logger;
        }

        public CarDetails GetCarDetails(string model)
        {
            var sw = Stopwatch.StartNew();
            var details = _carService.GetCarDetails(model);
            sw.Stop();

            _logger.LogInformation($"Retrieved car details for model: {model} in {sw.ElapsedMilliseconds} ms");

            return details;
        }
    }
}
