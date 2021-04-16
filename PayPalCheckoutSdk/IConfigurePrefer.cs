using System.Collections.Generic;

namespace PayPalCheckoutSdk
{
    public interface IConfigurePrefer
    {
        IDictionary<string, ICollection<string>> Headers { get; }
    }
}
