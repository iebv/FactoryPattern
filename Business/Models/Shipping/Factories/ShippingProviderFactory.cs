using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_First_Look.Business.Models.Shipping.Factories
{

    public abstract class ShippingProviderFactory
    {
        public abstract ShippingProvider CreateShippingProvider(string country);

        public ShippingProvider GetShippingProvider(string country)
        {
            var provider = CreateShippingProvider(country);

            if (country == "Sweden" &&
                provider.InsuranceOptions.ProviderHasInsurance)
            {
                provider.RequireSignature = false;
            }

            return provider;
        }
    }
}
