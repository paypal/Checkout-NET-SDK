using System.Collections.Generic;

namespace PayPalCheckoutSdk.RequestInterfaces
{
    public interface IConfigurePayPalRequestId
    {
        IDictionary<string, ICollection<string>> Headers { get; }
    }
}
