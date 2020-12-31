using System.Text;

namespace Factory_Pattern_First_Look.Business.Models.Commerce.Invoice
{
    public class GSTInvoice : IInvoice
    {
        public byte[] GenerateInvoice()
        {
            return
                Encoding.Default.GetBytes("Hello world from a GST Invoice");
        }
    }

}
