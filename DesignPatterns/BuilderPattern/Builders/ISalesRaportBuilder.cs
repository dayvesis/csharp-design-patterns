using BuilderPattern.Products;
using System.Collections.Generic;

namespace BuilderPattern.Builders
{
    public interface ISalesRaportBuilder
    {
        void BuildHeader(string header);
        void BuildItems(IEnumerable<SaleItem> items);
        void BuildSummary();
        void BuildFooter(string footer);
    }
}
