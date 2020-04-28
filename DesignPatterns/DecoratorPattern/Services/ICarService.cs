using DecoratorPattern.Model;

namespace DecoratorPattern.Services
{
    public interface ICarService
    {
        CarDetails GetCarDetails(string model);
    }
}
