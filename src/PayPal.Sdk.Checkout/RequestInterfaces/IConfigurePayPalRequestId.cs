using System.Collections.Generic;

namespace PayPal.Sdk.Checkout.RequestInterfaces
{
    public interface IConfigurePayPalRequestId
    {
        IDictionary<string, ICollection<string>> Headers { get; }
    }
}
