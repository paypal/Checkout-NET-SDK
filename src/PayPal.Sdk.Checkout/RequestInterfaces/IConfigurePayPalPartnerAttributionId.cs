using System.Collections.Generic;

namespace PayPal.Sdk.Checkout.RequestInterfaces
{
    public interface IConfigurePayPalPartnerAttributionId
    {
        IDictionary<string, ICollection<string>> Headers { get; }
    }
}
