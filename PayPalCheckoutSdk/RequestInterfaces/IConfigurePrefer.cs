using System.Collections.Generic;

namespace PayPalCheckoutSdk.RequestInterfaces
{
    public interface IConfigurePrefer
    {
        IDictionary<string, ICollection<string>> Headers { get; }
    }
}
