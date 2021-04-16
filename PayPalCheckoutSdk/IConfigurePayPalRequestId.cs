using System.Collections.Generic;

namespace PayPalCheckoutSdk
{
    public interface IConfigurePayPalRequestId
    {
        IDictionary<string, ICollection<string>> Headers { get; }
    }
}
