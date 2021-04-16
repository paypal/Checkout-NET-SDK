// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// PurchaseUnitRequest.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT

using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The purchase unit request. Includes required information for the payment contract.
    /// </summary>
    [DataContract]
    public class PurchaseUnitRequest
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public PurchaseUnitRequest()
        {
        }

        /// <summary>
        /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.<br/>If you specify `amount.breakdown`, the amount equals `item_total` plus `tax_total` plus `shipping` plus `handling` plus `insurance` minus `shipping_discount` minus discount.<br/>The amount must be a positive number. For listed of supported currencies and decimal precision, see the PayPal REST APIs <a href="/docs/integration/direct/rest/currency-codes/">Currency Codes</a>.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public AmountWithBreakdown AmountWithBreakdown { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external ID. Used to reconcile client transactions with PayPal transactions. Appears in transaction and settlement reports but is not visible to the payer.
        /// </summary>
        [DataMember(Name = "custom_id", EmitDefaultValue = false)]
        public string CustomId { get; set; } = null!;

        /// <summary>
        /// The purchase description.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public string InvoiceId { get; set; } = null!;

        /// <summary>
        /// An array of items that the customer purchases from the merchant.
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<Item> Items { get; set; } = null!;

        /// <summary>
        /// The merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
        /// </summary>
        [DataMember(Name = "payee", EmitDefaultValue = false)]
        public Payee Payee { get; set; } = null!;

        /// <summary>
        /// Any additional payment instructions for PayPal for Partner customers. Enables features for partners and marketplaces, such as delayed disbursement and collection of a platform fee. Applies during order creation for captured payments or during capture of authorized payments.
        /// </summary>
        [DataMember(Name = "payment_instruction", EmitDefaultValue = false)]
        public PaymentInstruction PaymentInstruction { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external ID for the purchase unit. Required for multiple purchase units when you must update the order through `PATCH`. If you omit this value and the order contains only one purchase unit, PayPal sets this value to `default`.
        /// </summary>
        [DataMember(Name = "reference_id", EmitDefaultValue = false)]
        public string ReferenceId { get; set; } = null!;

        /// <summary>
        /// The shipping details.
        /// </summary>
        [DataMember(Name = "shipping", EmitDefaultValue = false)]
        public ShippingDetail ShippingDetail { get; set; } = null!;

        /// <summary>
        /// The payment descriptor on account transactions on the customer's credit card statement. The maximum length of the soft descriptor is 22 characters. Of this, the PayPal prefix uses eight characters (`PAYPAL *`). So, the maximum length of the soft descriptor is:<pre>22 - length(PayPal *) - length(<var>soft_descriptor_in_profile</var> + 1)</pre>If the total length of the `soft_descriptor` exceeds 22 characters, the overflow is truncated.<br/><br/>For example, if:<ul><li>The PayPal prefix toggle is <code>PAYPAL *</code>.</li><li>The merchant descriptor in the profile is <code>VENMO</code>.</li><li>The soft descriptor is <code>JanesFlowerGifts LLC</code>.</li></ul>Then, the descriptor on the credit card is <code>PAYPAL *VENMO JanesFlo</code>.
        /// </summary>
        [DataMember(Name = "soft_descriptor", EmitDefaultValue = false)]
        public string SoftDescriptor { get; set; } = null!;
    }
}
