using System;

namespace FactoryPattern.Model
{
    public class CarToy : IToy
    {
        public void Describe() => Console.WriteLine("This is super cool car toy with nice tyres");
    }
}
