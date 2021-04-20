// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// Refund.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data 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
// DO NOT EDIT

using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.Sdk.Checkout.Payments
{
    /// <summary>
    /// The refund information.
    /// </summary>
    [DataContract]
    public class Refund
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Refund()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount { get; set; } = null!;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; } = null!;

        /// <summary>
        /// The PayPal-generated ID for the refund.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public string InvoiceId { get; set; } = null!;

        /// <summary>
        /// An array of related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links { get; set; } = null!;

        /// <summary>
        /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "note_to_payer", EmitDefaultValue = false)]
        public string NoteToPayer { get; set; } = null!;

        /// <summary>
        /// The breakdown of the refund.
        /// </summary>
        [DataMember(Name = "seller_payable_breakdown", EmitDefaultValue = false)]
        public MerchantPayableBreakdown SellerPayableBreakdown { get; set; } = null!;

        /// <summary>
        /// The status of the capture.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; } = null!;

        /// <summary>
        /// The details of the refund status.
        /// </summary>
        [DataMember(Name = "status_details", EmitDefaultValue = false)]
        public StatusDetails StatusDetails { get; set; } = null!;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; } = null!;
    }
}
