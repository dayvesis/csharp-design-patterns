namespace NullObjectPattern.Model
{
    public class Car : ICar
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }

        public Car(int id, string model, string manufacturer)
        {
            Id = id;
            Model = model;
            Manufacturer = manufacturer;
        }
    }
}
