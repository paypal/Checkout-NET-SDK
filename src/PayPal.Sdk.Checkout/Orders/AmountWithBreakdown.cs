// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// AmountWithBreakdown.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+yZ32vjRhDH3/tXDHpqQbHSH1Aw9CG9ayEtvTN3plCSYI9Xo2i41a5ufyQnSv/3svplyXabBtKX8755Z1ezM19/50Mi/5msm5qSZYKV9sptHtmVm50h/JDrR5Wkye9oGHeS3mD1b8d+paY/kaTJa7LCcO1Yq2SZrEsCpx1K0CYnA10KCCkAFej2HEoY04Er0UFt9APnZCEnhyxtCtaLEtCCGxOyo6rPl/Yhh5/GiC25rlndp1CiymX7iZX1BpWgFFDlkLMV4bBNgQtA1Sxu/eXlt2JnsvYDXRfQaA+2JsFFA9su92Isdpu29fRN0UeP0sI2FLZpC9pCLb2FrcNP88BQ3LAeShzWY6FbqFhNn9gMRQ87w/qw9vW+sMpbBzsChFpbdvxAoHy1I7OAn7UBydZRDroA6+tam7AQ3hhSgsl2SpHgCiXUhgRb1ioFS9Q2v8JmhRLe/fR+DVerawtdHQiloeKH2yTLtbAZK0f3BsO3neVsSLjMkHVZf09zIXRONrtNuuJf9WF4FcJdxgy7vUWSJlfGYNOZ9zJN3hHmb5VskmWB0lIIfPRsKB8DK6NrMo7JJsubQ9s/7fjTZp9Gj12/d7QuJi5ZwI/jxqHL9yb/3wz+Ytr9phU1x4INN86EmgSPdRoc0BbcG7bQBhAKVqgEh7YNKovCdcbrRULYoQy9gjZQY1ORcpD7F/SHdYbV/XGTQ8mbYNpZp4c7x+3euNIQXYgSDQpHBq7fv7347puvv98LEZ69+/JZc/NVh03OSTkuwtS6ibTPUsQZfyCI8lL+lT6pygNKP1djiByr0O6k8FiyKKHi+zLwadnNuZfdnHcryd3qSkGrBZnWHRM+Sf5AsP1l9ce2EwENgdIOXFOzQCkbKEznHZQ9JLMh68EdI+eGJ07ftX7zenKX9bucwxznoUINrtTeospdaU9flw0dBviG78n04vdUDsAYgStRkO0HYuaQjsA3c1I+1zYv4Yy7iTf+gQoDoGbumAQjFSIVIhXOjQrjHysze0yjkQuRC5ELZ8eF8f/nORim4UiGSIZIhnMjw/DKY+aOSTBSIVIhUuFcqbA5+fLx1G7kRORE5MS5cWL8FW5mj2k0ciFyIXLhM+PC3X9wR5yZODNxZvYz88XfAAAA//8=
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.<br/>If you specify `amount.breakdown`, the amount equals `item_total` plus `tax_total` plus `shipping` plus `handling` plus `insurance` minus `shipping_discount` minus discount.<br/>The amount must be a positive number. For listed of supported currencies and decimal precision, see the PayPal REST APIs <a href="/docs/integration/direct/rest/currency-codes/">Currency Codes</a>.
    /// </summary>
    [DataContract]
    public class AmountWithBreakdown
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public AmountWithBreakdown()
        {
        }

        /// <summary>
        /// The breakdown of the amount. Breakdown provides details such as total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.
        /// </summary>
        [DataMember(Name = "breakdown", EmitDefaultValue = false)]
        public AmountBreakdown AmountBreakdown { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
        /// </summary>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The value, which might be:<ul><li>An integer for currencies like `JPY` that are not typically fractional.</li><li>A decimal fraction for currencies like `TND` that are subdivided into thousandths.</li></ul>For the required number of decimal places for a currency code, see [Currency Codes](/docs/integration/direct/rest/currency-codes/).
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; } = null!;
    }
}
