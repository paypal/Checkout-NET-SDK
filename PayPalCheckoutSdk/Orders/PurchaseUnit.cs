// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// PurchaseUnit.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT

using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The purchase unit details. Used to capture required information for the payment contract.
    /// </summary>
    [DataContract]
    public class PurchaseUnit
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public PurchaseUnit()
        {
        }

        /// <summary>
        /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.<br/>If you specify `amount.breakdown`, the amount equals `item_total` plus `tax_total` plus `shipping` plus `handling` plus `insurance` minus `shipping_discount` minus discount.<br/>The amount must be a positive number. For listed of supported currencies and decimal precision, see the PayPal REST APIs <a href="/docs/integration/direct/rest/currency-codes/">Currency Codes</a>.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public AmountWithBreakdown AmountWithBreakdown { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external ID. Used to reconcile API caller-initiated transactions with PayPal transactions. Appears in transaction and settlement reports.
        /// </summary>
        [DataMember(Name = "custom_id", EmitDefaultValue = false)]
        public string CustomId { get; set; } = null!;

        /// <summary>
        /// The purchase description.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// The PayPal-generated ID for the purchase unit. This ID appears in both the payer's transaction history and the emails that the payer receives. In addition, this ID is available in transaction and settlement reports that merchants and API callers can use to reconcile transactions. This ID is only available when an order is saved by calling <code>v2/checkout/orders/id/save</code>.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external invoice ID for this order.
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
        /// The collection of payments, or transactions, for a purchase unit in an order. For example, authorized payments, captured payments, and refunds.
        /// </summary>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        public PaymentCollection Payments { get; set; } = null!;

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
