// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// TaxInfo.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6yRT0vDQBBH736KYS9eQrDgKTelFxG0aPAi0k6zk2Zxs7vObLSL9LtL0j9ordCCx/nlkfBePlWZAqlCRVxOjau9ytQTssG5pTts957cUtqMKlNjkopNiMY7VaiyIYi4hJsx+BpiQ1B1En1LnEP57QIjgFY8vDr/4QBlYAOmHrz2sYHZ8EE9A3R6e0xjCjQDZAKmt84w6Vxl6ooZ01rgIlMPhPre2aSKGq1QP6zR3TBhH4ijIVHF805dIhu3+ENc/9DeTb/lt4LnsumQw2MXgudIGmrPg+cE0wRtr9uSi9BSbLwG72zKoUzBVGhtygZ0E9MIjEZQNchYRWIB691ieJ9x2rwb3aGVIdXo8iA278Q4EiE5qVjkbi+Y66xdZUdWG37YgXTb/Yh+0KMnRvwHw5fV2RcAAAD//w==
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The tax ID of the customer. The customer is also known as the payer. Both `tax_id` and `tax_id_type` are required.
    /// </summary>
    [DataContract]
    public class TaxInfo
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public TaxInfo()
        {
        }

        /// <summary>
        /// REQUIRED
        /// The customer's tax ID. Supported for the PayPal payment method only. Typically, the tax ID is 11 characters long for individuals and 14 characters long for businesses.
        /// </summary>
        [DataMember(Name = "tax_id", EmitDefaultValue = false)]
        public string TaxId { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The customer's tax ID type. Supported for the PayPal payment method only.
        /// </summary>
        [DataMember(Name = "tax_id_type", EmitDefaultValue = false)]
        public string TaxIdType { get; set; } = null!;
    }
}
