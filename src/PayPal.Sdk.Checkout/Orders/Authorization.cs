// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Authorization.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT

using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The authorized payment transaction.
    /// </summary>
    [DataContract]
    public class Authorization
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Authorization()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount { get; set; } = null!;

        /// <summary>
        /// The details of the authorized payment status.
        /// </summary>
        [DataMember(Name = "status_details", EmitDefaultValue = false)]
        public AuthorizationStatusDetails AuthorizationStatusDetails { get; set; } = null!;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; } = null!;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "expiration_time", EmitDefaultValue = false)]
        public string ExpirationTime { get; set; } = null!;

        /// <summary>
        /// The PayPal-generated ID for the authorized payment.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public string InvoiceId { get; set; } = null!;

        /// <summary>
        /// An array of related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links { get; set; } = null!;

        /// <summary>
        /// The level of protection offered as defined by [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
        /// </summary>
        [DataMember(Name = "seller_protection", EmitDefaultValue = false)]
        public SellerProtection SellerProtection { get; set; } = null!;

        /// <summary>
        /// The status for the authorized payment.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; } = null!;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; } = null!;
    }
}
