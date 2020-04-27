using BuilderPattern.Products;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern.Builders
{
    public class SalesRaportBuilder : ISalesRaportBuilder
    {
        private SalesRaport _salesRaport = new SalesRaport();

        public SalesRaportBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _salesRaport = new SalesRaport();
        }

        public void BuildFooter(string footer)
        {
            _salesRaport.Footer = footer;
        }

        public void BuildHeader(string header)
        {
            _salesRaport.Header = header;
        }

        public void BuildItems(IEnumerable<SaleItem> items)
        {
            _salesRaport.Items = items;
        }

        public void BuildSummary()
        {
            if (_salesRaport.Items != null && _salesRaport.Items.Any())
            {
                var totalSoldItems = _salesRaport.Items.Sum(i => i.SoldQuantity);
                var totalProfit = _salesRaport.Items.Sum(i => i.Price * i.SoldQuantity);
                _salesRaport.Summary = $"Total profit: {totalProfit}$, Total sold items: {totalSoldItems}";
            }
        }

        public ISalesRaport GetRaport()
        {
            var raport = _salesRaport;

            Reset();

            return raport;
        }
    }
}
