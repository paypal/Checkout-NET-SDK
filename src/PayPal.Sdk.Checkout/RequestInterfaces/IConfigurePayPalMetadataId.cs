using System.Collections.Generic;

namespace PayPal.Sdk.Checkout.RequestInterfaces
{
    public interface IConfigurePayPalMetadataId
    {
        IDictionary<string, ICollection<string>> Headers { get; }
    }
}
