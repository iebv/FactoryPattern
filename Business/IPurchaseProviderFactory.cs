using Factory_Pattern_First_Look.Business.Models.Commerce;
using Factory_Pattern_First_Look.Business.Models.Commerce.Invoice;
using Factory_Pattern_First_Look.Business.Models.Commerce.Summary;
using Factory_Pattern_First_Look.Business.Models.Shipping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_First_Look.Business
{
    public interface IPurchaseProviderFactory
    {
        ShippingProvider CreateShippingProvider(Order order);
        IInvoice CreateInvoice(Order order);
        ISummary CreateSummary(Order order);
    }
}
