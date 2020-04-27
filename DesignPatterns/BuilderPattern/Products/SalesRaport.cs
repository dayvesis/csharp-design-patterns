using System;
using System.Collections.Generic;

namespace BuilderPattern.Products
{
    public class SalesRaport : ISalesRaport
    {
        public string Header { get; set; }
        public IEnumerable<SaleItem> Items { get; set; }
        public string Summary { get; set; }
        public string Footer { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Header}\n\n");

            foreach (var item in Items)
            {
                Console.WriteLine($"Name: {item.Name}\t, Price: {item.Price}\t, Sold: {item.SoldQuantity}");
            }

            Console.WriteLine($"{Summary}\n\n");
            Console.WriteLine($"{Footer}\n\n");
        }
    }
}
