// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// PaymentSource.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The payment source definition.
    /// </summary>
    [DataContract]
    public class PaymentSource
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public PaymentSource()
        {
        }

        /// <summary>
        /// The payment card to use to fund a payment. Can be a credit or debit card.
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public Card Card { get; set; } = null!;

        /// <summary>
        /// The tokenized payment source to fund a payment.
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public Token Token { get; set; } = null!;
    }
}
