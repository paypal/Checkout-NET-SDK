// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// TaxInformation.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6yRTUvDQBBA7/6KYS9eQrDgKTelFxG0aPAi0k6zk2Zxs7vObLSL9L9L0g8/2kMLHmd4TPLefqoyBVKFKnEJN6723GI03qlMPSEbnFu6w7YHVKZuKX0PY5KKTRjgQpUNQexPjMHXEBuCqpPoW+Icyh8TGAG04uHV+Q8HKAMbMPXgtY8NzCIup0bPAJ3eDtOYAs0AmYDprTNMOleZumLGtP7/i0w9EOp7Z5MqarRC/WKN7hYT9oE4GhJVPO/MJbJxi33h9ad/ae9W+/JbwXPZdMjhsQvBcyQNtefBc4JpgrbXbclFaCk2XoN3NuVQpmAqtDZlA7qJaQRGI6gaZKwisYD1bjHcM06bd6M7tDKkGl0exOadGEciJCcVi9z9CeY6a1fZkdWGBzuQbrs/oh/06IkR/8HwZXX2BQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The tax ID of the customer. The customer is also known as the payer. Both `tax_id` and `tax_id_type` are required.
    /// </summary>
    [DataContract]
    public class TaxInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TaxInformation() {}

        /// <summary>
        /// REQUIRED
        /// The customer's tax ID. Supported for the PayPal payment method only. Typically, the tax ID is 11 characters long for individuals and 14 characters long for businesses.
        /// </summary>
        [DataMember(Name="tax_id", EmitDefaultValue = false)]
        public string TaxId;

        /// <summary>
        /// REQUIRED
        /// The customer's tax ID type. Supported for the PayPal payment method only.
        /// </summary>
        [DataMember(Name="tax_id_type", EmitDefaultValue = false)]
        public string TaxIdType;
    }
}

