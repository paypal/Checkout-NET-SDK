// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// PayeeBase.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/7xUwW7bOBC971cMdFacINnswafdIIcNCqRB4fbSFvaYfLKIUKQyJO2oRf69IOW4dtyiBVr0IkCPHMx7b+bxczUbelTTqucBmC85oKqrdyyGlxa33B2dvcKwhau6ukZQYvpovKum1awFaUQ2NlDjhWIL6iCqZRdp03oSKJg1QjlpktOB2Glqkm2MtSPsRUMmNNuvNYHYBk/3zm8c8XixsJpUdfWfCA+jjLO6egPWr50dqmnDNiADD8kI9A64E99DokGopu93BoQoxq2OxStr4OLc6APt++ixCX1aWqPo5npnQyF7Ql52ok6UgCM0cd9P6MZF8TopaIqeQup7L5FSACkOCDWFpNqs/ErYuJkAZFzESji3pY2JLd3xcMe2pk0L2XakBTo2ds5aC0JYZAKLZwZzoxfZWucj8ZqNzap/1VCXrH2qf+hqoXXg6AHRb7qaBYsrgtmaT9BUamhbM/mQzs4u1NJ6df+QfET5H78qRPFuNSK3PmI6wqf7OL3ts/n//E2qZWEVIYFYQGyt30DTEo3Pv07T+eXl925xEzEOfeyhvN5S+Xfb9CtCwazchP73G6whdalawUHY2oFYKfR5RTp+NF3qyMKtYluWit2h+jzI88t96mOGeo7ZNVpDTGNK9Djm6uSKSfpnWRIeTYjPLp++tPnPrM3e6h4szyF+vDpjNEomhG6uc0aMasu7Qh2He+hsUMhR8k2ZwraClfLJRXKpW0LKCjoNXUaQ01mCF1sjmnouWkbbX9YFEpQOSzsQnJKhDDavElMvvheDyDLQOgt2MdO44oCL81ybwvguwOWhFH6CkGz8LWn9+PTXFwAAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The details for the merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
    /// </summary>
    [DataContract]
    public class PayeeBase
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public PayeeBase()
        {
        }

        /// <summary>
        /// The public ID for the payee- or merchant-created app. Introduced to support use cases, such as BrainTree integration with PayPal, where payee `email_address` or `merchant_id` is not available.
        /// </summary>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; } = null!;

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [DataMember(Name = "email_address", EmitDefaultValue = false)]
        public string Email { get; set; } = null!;

        /// <summary>
        /// The PayPal payer ID, which is a masked version of the PayPal account number intended for use with third parties. The account number is reversibly encrypted and a proprietary variant of Base32 is used to encode the result.
        /// </summary>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; } = null!;
    }
}
