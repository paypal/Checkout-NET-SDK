using System.Collections.Generic;

namespace PayPalCheckoutSdk
{
    public interface IConfigurePayPalMetadataId
    {
        IDictionary<string, ICollection<string>> Headers { get; }
    }
}
