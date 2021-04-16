using System.Collections.Generic;

namespace PayPalCheckoutSdk.RequestInterfaces
{
    public interface IConfigurePayPalPartnerAttributionId
    {
        IDictionary<string, ICollection<string>> Headers { get; }
    }
}
