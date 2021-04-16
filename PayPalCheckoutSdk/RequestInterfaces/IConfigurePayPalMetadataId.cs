using System.Collections.Generic;

namespace PayPalCheckoutSdk.RequestInterfaces
{
    public interface IConfigurePayPalMetadataId
    {
        IDictionary<string, ICollection<string>> Headers { get; }
    }
}
