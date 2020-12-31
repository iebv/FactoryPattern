using System;
using System.Collections.Generic;

namespace Factory_Pattern_First_Look.Business.Models.Commerce.Invoice
{
    public interface IInvoice
    {
        public byte[] GenerateInvoice();
    }

}
