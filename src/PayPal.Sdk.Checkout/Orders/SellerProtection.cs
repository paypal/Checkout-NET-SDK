// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// SellerProtection.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/9SSwYrUQBCG7z5F0SeFOPHkIbcFEUTUQRcvy7LUJH8mDT3dbVVlQyP77tIZ2dlxFPHo9a8uqr6v67u7Lhmuc4oQIHdZkqE3n6Jr3FcWz7uAj3z405P3KD+rrnFvoL34vJY6dz2BAu4RKI10aqI0jhAMxEoDRh8x0K7QzZbLlgN9WYfQ9vR+TEIfIP3E0fT2+WSWtWvbZVk2mUvmsOnToZ21XbDjnLU95Nwq+lm8lfa49MvT/Bcb17grES5H8leN+wwePsVQXDdyUNTg2+wFw2OwlZQh5qGuuzk5M/Fxfylq8Jpnw13Phn2S2vXU1G/L5+6uInFdsarrUxx8zZVsYiMWUJ/uV4fVjU0gE47KK98veK//FS/OITw0f2VUY5vPuR6jc5Z3cfAVVWmZYBMuNiavhOD3fhewEh3/7MnNbOhtEvJxTHLgGjSkwH90M6vU24dnPwAAAP//
// DO NOT EDIT

using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.Sdk.Checkout.Orders
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
        /// Indicates whether the transaction is eligible for seller protection. For information, see [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ESellerProtectionStatus Status { get; set; }
    }
}
