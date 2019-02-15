// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// PaymentMethod.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6yRT0szQQzG7++nGHLevnjem+BN1CLFi0iJs0/dgflnJnsYpN9d1tqxsgoeekyekPx+5I02NYN6WnMNiGpuoGMaqKMHFsfPHrcc5pw6ukb9Kq5QrLisLkXqaTPC2KloChDDcTABYkeOavLn3izYQRAtyn/q6FKE6+H0RUf34OEu+kr9jn3B3HidnGBojbWkDFGHQv1jgy4qLr4sYTNXYHs4OW85ZV9mS5Uj/aqNNY+SJjmDQ5y833d/EpFtgYfVHzy+Rb9/ZHWcahbh48smRaMnuqY4xVnMnvb/3gEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The customer and merchant payment preferences.
    /// </summary>
    [DataContract]
    public class PaymentMethod
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentMethod() {}

        /// <summary>
        /// The merchant-preferred payment sources.
        /// </summary>
        [DataMember(Name="payee_preferred", EmitDefaultValue = false)]
        public string PayeePreferred;

        /// <summary>
        /// The customer-selected payment method on the merchant site.
        /// </summary>
        [DataMember(Name="payer_selected", EmitDefaultValue = false)]
        public string PayerSelected;
    }
}

