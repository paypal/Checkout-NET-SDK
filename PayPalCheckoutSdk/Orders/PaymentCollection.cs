// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// PaymentCollection.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT

using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The collection of payments, or transactions, for a purchase unit in an order. For example, authorized payments, captured payments, and refunds.
    /// </summary>
    [DataContract]
    public class PaymentCollection
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public PaymentCollection()
        {
        }

        /// <summary>
        /// An array of authorized payments for a purchase unit. A purchase unit can have zero or more authorized payments.
        /// </summary>
        [DataMember(Name = "authorizations", EmitDefaultValue = false)]
        public List<Authorization> Authorizations { get; set; } = null!;

        /// <summary>
        /// An array of captured payments for a purchase unit. A purchase unit can have zero or more captured payments.
        /// </summary>
        [DataMember(Name = "captures", EmitDefaultValue = false)]
        public List<Capture> Captures { get; set; } = null!;

        /// <summary>
        /// An array of refunds for a purchase unit. A purchase unit can have zero or more refunds.
        /// </summary>
        [DataMember(Name = "refunds", EmitDefaultValue = false)]
        public List<Refund> Refunds { get; set; } = null!;
    }
}
