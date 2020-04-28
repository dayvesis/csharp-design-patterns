using PrototypePattern.Manager;
using PrototypePattern.Prototype;
using System.Collections.Generic;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var prototypeManager = new PrototypeManager();

            var order1 = new OrderDetails()
            {
                OrderId = 101,
                OrderItems = new List<string>() { "Pizza", "Cake", "Soda" },
                TotalValue = 23.50m
            };            
            
            var order2 = new OrderDetails()
            {
                OrderId = 102,
                OrderItems = new List<string>() { "Cheeseburger", "Hamburger", "Soda", "Chicken strips" },
                TotalValue = 32.80m
            };

            prototypeManager[$"Order::{order1.OrderId}"] = order1;
            prototypeManager[$"Order::{order2.OrderId}"] = order2;

            var copiedOrder1 = prototypeManager["Order::101"].Clone() as OrderDetails;
            var copiedOrder2 = prototypeManager["Order::102"].Clone() as OrderDetails;

            copiedOrder1.Print();
            copiedOrder2.Print();
        }
    }
}
