// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// SellerProtection.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/6SSQavUQAzH736KMCeFuvXkobcHXkTUog8vj4ekM+l2YHZmTNItg+x3l+lCd9cVRDz23zTJ75f+NI8lk+nMVwqBGHpOSlZ9iqYx35A9DoE+4aGWmMZ8oHJ5eEdi2ee1uDOPE0GgIwVII+StDaRxJCYHKOBo9JEcDAWeeiw9BrgbC2Ni+EhsJ4wqzy8n1Sxd2y7LsstYMoadTYd2lnahAXOW9pBzK2Rn9lpaWfu9vsx/tTONeWDGcgZ905gvhO5zDMV0IwahGvyYPZPbgp5TJlZPYrqnTZEo+7i/9+K85Fnpu0WlfeL61bWpP76+dfcQAeuKVZ1N0fmaC+iECsgENh1Xh9WNTgTKGAVXvt/w3v4rXpxDODV/ZRRFnW+5tuiW5X10vqIKLBPpRHcbgxeg4Pd+CLQSnW929c/878lWpufTi18AAAD//w==
// DO NOT EDIT

using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.Sdk.Checkout.Payments
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
        public SellerProtection()
        {
        }

        /// <summary>
        /// An array of conditions that are covered for the transaction.
        /// </summary>
        [DataMember(Name = "dispute_categories", EmitDefaultValue = false)]
        public List<string> DisputeCategories { get; set; } = null!;

        /// <summary>
        /// Indicates whether the transaction is eligible for seller protection.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; } = null!;
    }
}
