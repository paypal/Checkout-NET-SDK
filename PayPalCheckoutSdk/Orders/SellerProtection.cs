// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// SellerProtection.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/9SSwYrUQBCG7z5F0SeFOPHkIbcFEUTUQRcvyyI1yZ9JQ093W1XZ0Mi+u3QWsjuOIB73mD+Vqvq+1C93XTJc574hBAjtJRl68ym6xn1n8XwI+MynWuIa9xHl8eEdtBef1+LOXU+ggDsESiPlrQ2lcYRgIFYaMPqIgQ6FbvZc9hzoYiyNSegTpJ84mt6+nMyydm27LMsuc8kcdn06tbO2Cw6cs7annFtFP4u30ura7/Xj/Fc717grES4PoG8a9xU8fImhuG7koKjBz9kLhi3YS8oQ81DX3WyK1MTH46WXwWueDT96NhyT1K+emvrr63N3V5G4rljV9SkOvuZKNrERC6hPd6vD6sYmkAlH5ZXvD7y3/4sX5xDum38yqrHN51xbdM7yIQ6+oiotE2zCxcbklRD80R8CVqKHf/bkZnb0Pgn5OCY5cQ0aUuAZ3cwq9fb+xW8AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The level of protection offered as defined by [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
    /// </summary>
    [DataContract]
    public class SellerProtection
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public SellerProtection() {}

        /// <summary>
        /// An array of conditions that are covered for the transaction.
        /// </summary>
        [DataMember(Name="dispute_categories", EmitDefaultValue = false)]
        public List<string> DisputeCategories;

        /// <summary>
        /// Indicates whether the transaction is eligible for seller protection. For information, see [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue = false)]
        public string Status;
    }
}

