// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// AmountBreakdown.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+yYXWvbTBCF799fMejqLShR+gEF36UJhbY0CW0olDQ4492xNWS1q86ukoiS/14kWaoUO5RAruq9snV29mOOjx4s/UrO65KSWYKFq2yYL4TwWrtbm6TJNxTGhaETLB6p+ET1ejBJk2PySrgM7GwyS85zgqEU3BJCTtAtsQ/vhoFS3A1r8qApIBsPvlI5oIfgAhrgQMV6VrqWAt4Nis+5LNmuUsjRatN+Y+srQasoBbQaNHvVFPsUeAlo6/0kTQ5FsO4aP0iTL4T61Jo6mS3ReGqEnxUL6UE4E1eSBCafzC4Gyz47S/WmT/2OE39G4qZPqhIhq+r2wF1vsHQCCEu2aBU3bQtaj6qZlQ4mISzQNL2CEyixLsgG0BU9X48+CNvVZpP9kefKaZp0+nBks92LkAvRnspRUAUS+PD1dO/Nq5dv/xjRzL38P9NO+YxtoJVgs0CmWUiFTMiHrC/ea4p99gJCjgFYkw28ZPJt4vqiJzkSpHpgiK2MuU//6soNmmrqRq9sutCOpHCbs8qh4FUeYEGzH9XBwWtVmfaTuivD3dWhhdYLkjYd69aaTg1fE1x9PPt+1ZmAQmBdgFCXrNCYGpbSZQfNfrdo1q/6YA/QpLhAM8zYvtf5yfFoL18tNDf3sW5O6CDkrvJodcj99u2yvsP3TtrfSdbmg62KBUkDjP4gpUFFfn1DTBKSgieCi6NeO2qC8NTYPEcyLkfZeIQKPaAm6RiJkQqRCpEKu0aF4c/KJB5jNXIhciFyYee4EKiYt887UzCM5UiGSIZIhl0jQ//KY5KOkRipEKkQqbCrVJhvffm4bTRyInIicmLXOBHwbstjxViNXIhciFz4x7hwef/fbwAAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The breakdown of the amount. Breakdown provides details such as total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.
    /// </summary>
    [DataContract]
    public class AmountBreakdown
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public AmountBreakdown()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "discount", EmitDefaultValue = false)]
        public Money Discount { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "handling", EmitDefaultValue = false)]
        public Money Handling { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "insurance", EmitDefaultValue = false)]
        public Money Insurance { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "item_total", EmitDefaultValue = false)]
        public Money ItemTotal { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "shipping", EmitDefaultValue = false)]
        public Money Shipping { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "shipping_discount", EmitDefaultValue = false)]
        public Money ShippingDiscount { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "tax_total", EmitDefaultValue = false)]
        public Money TaxTotal { get; set; } = null!;
    }
}
