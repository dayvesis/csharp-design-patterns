using BuilderPattern.Builders;
using BuilderPattern.Directors;
using BuilderPattern.Products;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldItems = new List<SaleItem>()
            {
                new SaleItem { Name = "Phoenix Couch", Price = 999, SoldQuantity = 3 },
                new SaleItem { Name = "Comfortable Red Cushion", Price = 25.99m, SoldQuantity = 25 },
                new SaleItem { Name = "Industrial Chair", Price = 175.99m, SoldQuantity = 8 },
                new SaleItem { Name = "Simple Brown Table", Price = 85, SoldQuantity = 13 }
            };

            var builder = new SalesRaportBuilder();
            var director = new SalesRaportDirector(builder);
            
            director.BuildDailySalesRaport(soldItems);
            var dailyRaport = builder.GetRaport();

            director.BuildMonthlySalesRaportWithSummary(soldItems);
            var monthlyRaportWithSummary = builder.GetRaport();

            dailyRaport.Print();
            monthlyRaportWithSummary.Print();

            // Extra: Fluent builder
            var fluentBuilder = new FluentSalesRaportBuilder();
            var fluentRaport = fluentBuilder.BuildHeader("---- FLUENT RAPORT ----")
                                            .BuildItems(soldItems)
                                            .BuildSummary()
                                            .BuildFooter("---- ENT OF FLUENT RAPORT ----")
                                            .GetRaport();

            fluentRaport.Print();                                            
        }
    }
}
