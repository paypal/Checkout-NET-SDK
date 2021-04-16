// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// AuthorizeRequest.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The authorize an order request.
    /// </summary>
    [DataContract]
    public class AuthorizeRequest
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public AuthorizeRequest()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount { get; set; } = null!;

        /// <summary>
        /// The payment source definition.
        /// </summary>
        [DataMember(Name = "payment_source", EmitDefaultValue = false)]
        public PaymentSource PaymentSource { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external ID for the purchase unit. Required for multiple purchase units.
        /// </summary>
        [DataMember(Name = "reference_id", EmitDefaultValue = false)]
        public string ReferenceId { get; set; } = null!;
    }
}
