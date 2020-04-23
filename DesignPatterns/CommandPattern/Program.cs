using CommandPattern.Commands;
using CommandPattern.Invoker;
using CommandPattern.Receiver;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var waterTank = new WaterTank() { Capacity = 100.0m, CurrentAmount = 0.0m };
            var commandManager = new CommandManager();

            commandManager.Invoke(new FillWaterTankCommand(waterTank, 50.0m));
            Console.WriteLine(waterTank);
            commandManager.Invoke(new FillWaterTankCommand(waterTank, 60.0m));
            Console.WriteLine(waterTank);
            commandManager.Invoke(new FillWaterTankCommand(waterTank, 10.0m));
            Console.WriteLine(waterTank);
            commandManager.Undo();
            Console.WriteLine(waterTank);

            commandManager.Invoke(new UnfillWaterTankCommand(waterTank, 10.0m));
            Console.WriteLine(waterTank);
            commandManager.Invoke(new UnfillWaterTankCommand(waterTank, 100.0m));
            Console.WriteLine(waterTank);
            commandManager.Invoke(new UnfillWaterTankCommand(waterTank, 10.0m));
            Console.WriteLine(waterTank);
            commandManager.Undo();
            Console.WriteLine(waterTank);
        }
    }
}
