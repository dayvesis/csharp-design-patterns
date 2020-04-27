using FactoryPattern.Model;
using System;

namespace FactoryPattern.Factory
{
    public static class ToysFactory
    {
        public static IToy MakeToy(ToyType toyType) =>
            toyType switch
            {
                ToyType.Car => new CarToy(),
                ToyType.Robot => new RobotToy(),
                _ => throw new Exception($"Unsupported toy type: {toyType}")
            };
    }
}
