using System;
using System.Collections.Generic;

namespace PrototypePattern.Prototype
{
    public class OrderDetails : IPrototype, IOrderDetails
    {
        public int OrderId { get; set; }
        public IEnumerable<string> OrderItems { get; set; }
        public decimal TotalValue { get; set; }

        public IPrototype Clone()
        {
            return (IPrototype)MemberwiseClone();
        }

        public void Print()
        {
            Console.WriteLine($"[{OrderId}]\nOrder items: {string.Join(", ", OrderItems)}\nTotal value: {TotalValue} $\n\n");
        }
    }
}
