using System.Collections.Generic;

namespace PayPal.Sdk.Checkout.RequestInterfaces
{
    public interface IConfigurePrefer
    {
        IDictionary<string, ICollection<string>> Headers { get; }
    }
}
