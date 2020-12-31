﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_First_Look.Business.Models.Commerce.Invoice
{
    public interface IInvoice
    {
        public byte[] GenerateInvoice();
    }


    public class GSTInvoice : IInvoice
    {
        public byte[] GenerateInvoice()
        {
            return
                Encoding.Default.GetBytes("Hello world from a GST Invoice");
        }
    }

    public class VATInvoice : IInvoice
    {
        public byte[] GenerateInvoice()
        {
            return Encoding.Default.GetBytes("Hello world from a VAT Invoice");
        }
    }

    public class NoVATInvoice : IInvoice
    {
        public byte[] GenerateInvoice()
        {
            return Encoding.Default.GetBytes("Hello world from a NO VAT invoice");
        }
    }

}