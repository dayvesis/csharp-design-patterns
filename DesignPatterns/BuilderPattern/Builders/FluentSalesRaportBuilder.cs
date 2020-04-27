using BuilderPattern.Products;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern.Builders
{
    public class FluentSalesRaportBuilder : IFluentSalesRaportBuilder
    {
        private SalesRaport _salesRaport = new SalesRaport();

        public FluentSalesRaportBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _salesRaport = new SalesRaport();
        }

        public IFluentSalesRaportBuilder BuildFooter(string footer)
        {
            _salesRaport.Footer = footer;

            return this;
        }

        public IFluentSalesRaportBuilder BuildHeader(string header)
        {
            _salesRaport.Header = header;

            return this;
        }

        public IFluentSalesRaportBuilder BuildItems(IEnumerable<SaleItem> items)
        {
            _salesRaport.Items = items;

            return this;
        }

        public IFluentSalesRaportBuilder BuildSummary()
        {
            if (_salesRaport.Items != null && _salesRaport.Items.Any())
            {
                var totalSoldItems = _salesRaport.Items.Sum(i => i.SoldQuantity);
                var totalProfit = _salesRaport.Items.Sum(i => i.Price * i.SoldQuantity);
                _salesRaport.Summary = $"Total profit: {totalProfit}$, Total sold items: {totalSoldItems}";
            }

            return this;
        }

        public ISalesRaport GetRaport()
        {
            var raport = _salesRaport;

            Reset();

            return raport;
        }
    }
}
