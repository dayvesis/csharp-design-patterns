using FactoryPattern.Factory;
using FactoryPattern.Model;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var toy1 = ToysFactory.MakeToy(ToyType.Car);
            var toy2 = ToysFactory.MakeToy(ToyType.Robot);

            toy1.Describe();
            toy2.Describe();
        }
    }
}
