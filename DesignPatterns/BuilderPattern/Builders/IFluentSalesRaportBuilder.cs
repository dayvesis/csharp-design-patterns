using BuilderPattern.Products;
using System.Collections.Generic;

namespace BuilderPattern.Builders
{
    public interface IFluentSalesRaportBuilder
    {
        IFluentSalesRaportBuilder BuildHeader(string header);
        IFluentSalesRaportBuilder BuildItems(IEnumerable<SaleItem> items);
        IFluentSalesRaportBuilder BuildSummary();
        IFluentSalesRaportBuilder BuildFooter(string footer);
        ISalesRaport GetRaport();
    }
}
