namespace AdapterPattern
{
    public interface ILegacyCarService
    {
        decimal GetAverageConsumption(string model);
        int GetHorsePower(string model);
        int GetTopSpeed(string model);
    }
}
