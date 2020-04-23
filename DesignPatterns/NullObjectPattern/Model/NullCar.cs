namespace NullObjectPattern.Model
{
    public class NullCar : ICar
    {
        public int Id => -1;
        public string Model => "Empty car's model";
        public string Manufacturer => "Empty car's manufacturer";
    }
}
