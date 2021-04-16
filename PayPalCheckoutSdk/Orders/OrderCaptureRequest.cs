// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// OrderCaptureRequest.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// Completes an capture payment for an order.
    /// </summary>
    [DataContract]
    public class OrderCaptureRequest
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public OrderCaptureRequest()
        {
        }

        /// <summary>
        /// The payment source definition.
        /// </summary>
        [DataMember(Name = "payment_source", EmitDefaultValue = false)]
        public PaymentSource PaymentSource { get; set; } = null!;
    }
}
