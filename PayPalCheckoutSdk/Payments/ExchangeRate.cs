// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// ExchangeRate.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/+STQWvVQBDH736KYU8KeY0VRXg3wQoiWKnFSyky7v5fdiDZfZ2dPA3S7y55MS+UCF5663FnNv+d34/Mb3c97OG27uKXj5wa0BUbXOW+sQr/aPGZu7HtKvcJw3J4j+JV9iY5ua27jiDMAcoGsshGAQbtJKGQRRB3uU9GlsnndIAa7TR3lBPI96pIfhibnLJF6Kl25ir3TpWHadKXlbsCh8vUDm6747ZgLNz1oginwhfNe6gJitvenBiLqaRmDVdyrx7f5wcfsK57a/QbiwpsfGRlb1D6+PVy8/rV+duFy+eA2+d1yL7UkgyN8hhQB1F4qxXF6vnyZrxc6heTRAlIJjv5K/GxrKS+be+r/6ox1gb2bzXr3pNSc+C2xwMhc2WtYVK1ME+rcEYXd70cuMW0FuMm9EmM8u4INP17Cxd9yNqxGQJxoaMrKGWlAC8dt3QcgH6KxWOWZTp/Q0EasTIexkyVJp4emL/bZ0n2KNpu75/9AQAA//8=
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Payments
{
    /// <summary>
    /// The exchange rate that determines the amount to convert from one currency to another currency.
    /// </summary>
    [DataContract]
    public class ExchangeRate
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public ExchangeRate()
        {
        }

        /// <summary>
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
        /// </summary>
        [DataMember(Name = "PayPalCheckoutSdk_currency", EmitDefaultValue = false)]
        public string PayPalCheckoutSdkCurrency { get; set; } = null!;

        /// <summary>
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
        /// </summary>
        [DataMember(Name = "target_currency", EmitDefaultValue = false)]
        public string TargetCurrency { get; set; } = null!;

        /// <summary>
        /// The target currency amount. Equivalent to one unit of the PayPalCheckoutSdk currency. Formatted as integer or decimal value with one to 15 digits to the right of the decimal point.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; } = null!;
    }
}
