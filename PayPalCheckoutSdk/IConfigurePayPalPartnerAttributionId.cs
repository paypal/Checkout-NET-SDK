using System.Collections.Generic;

namespace PayPalCheckoutSdk
{
    public interface IConfigurePayPalPartnerAttributionId
    {
        IDictionary<string, ICollection<string>> Headers { get; }
    }
}
