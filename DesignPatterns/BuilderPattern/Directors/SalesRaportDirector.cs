using BuilderPattern.Builders;
using BuilderPattern.Products;
using System;
using System.Collections.Generic;

namespace BuilderPattern.Directors
{
    public class SalesRaportDirector
    {
        private readonly ISalesRaportBuilder _salesRaportBuilder;

        public SalesRaportDirector(ISalesRaportBuilder salesRaportBuilder)
        {
            _salesRaportBuilder = salesRaportBuilder;
        }

        public void BuildDailySalesRaport(IEnumerable<SaleItem> soldItems)
        {
            _salesRaportBuilder.BuildHeader("---- DAILY SALES RAPORT ----");
            _salesRaportBuilder.BuildItems(soldItems);
            _salesRaportBuilder.BuildFooter($"Generated at: {DateTime.Now:yyyy-MM-dd}");
        }

        public void BuildMonthlySalesRaportWithSummary(IEnumerable<SaleItem> soldItems)
        {
            _salesRaportBuilder.BuildHeader("---- MONTHLY SALES RAPORT ----");
            _salesRaportBuilder.BuildItems(soldItems);
            _salesRaportBuilder.BuildSummary();
            _salesRaportBuilder.BuildFooter($"Generated at: {DateTime.Now:yyyy-MM-dd}");
        }
    }
}
