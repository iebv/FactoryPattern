using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_First_Look.Business.Models.Commerce.Summary
{
    public interface ISummary
    {
        string CreateOrderSummary(Order order);
        void Send();
    }
}
