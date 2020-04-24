namespace AdapterPattern
{
    public class CarDetailsAdapter : ICarDetailsAdapter
    {
        private readonly ILegacyCarService _legacyCarService;

        public CarDetailsAdapter(ILegacyCarService legacyCarService)
        {
            _legacyCarService = legacyCarService;
        }

        public CarDetails GetCarDetails(string model)
        {
            var carDetails = new CarDetails() { Model = model };
            carDetails.Consumption = _legacyCarService.GetAverageConsumption(model);
            carDetails.Power = _legacyCarService.GetHorsePower(model);
            carDetails.TopSpeed = _legacyCarService.GetTopSpeed(model);

            return carDetails;
        }
    }
}
