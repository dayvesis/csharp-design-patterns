using System;

namespace FactoryPattern.Model
{
    public class RobotToy : IToy
    {
        public void Describe() => Console.WriteLine("This is finely crafted robot toy with laser eyes");
    }
}
