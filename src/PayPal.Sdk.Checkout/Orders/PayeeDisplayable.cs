// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// PayeeDisplayable.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/9yWUW/bNhDH3/cpDnpKANVOu6YPflrhFhgwICu6bC9dYJzIs0SEOqq8Ux1t6HcfKMquHdtAHrpu6EsQ3v/IO/7ub0l/F7dDR8Wi6HAgWlknnccBK09FWfyB0aV/b7A9l/ILDZNalMUbEhNdpy5wsShuG4KWommQFRyvQ2wxSTM4VATQS4B7DhsGFNCGYCw1g9ddRxgFNIxR04uGliI4BtOQuQ+9lqARWdCko6UEatF5iGTIdSolINv9DGicaIjDrCiL1zHikK9/VRbvCe2v7IdisUYvlAIfexfJ7gLvYugoqiMpFh924ESj4/qYVhWR7YrTYh/TQfgYWBIgrMfrbhE9kUOHQ0us/w0P7r3/XO6gvGsCn3BQ1YtjEll1k77H5bF0zGZUgPu2olimuzsVMMiBnUEPjpUijxZDDx/ezp6/ejllO66h88iQTXh30ah2spjPN5vNzGk/c6zzSGZ+++z92+Wzceuc+PLfd4kJPWscVga9d1yvTLCHXHYJWTimMiXAdAKkRLhYLi+/ESLITbSVY7LgiWtttg5eLrPfRmNPVXM5aHtR4KBQEdSRUCmCNsjw/Bqsq51KPvnxPhNYnKikEvhFtSTq8moicPNmeTlWl75KzNLm6YyL324uv7Lhz82XHpRYXOBVrn0w2xPi8Xx3SVP336jxLdlTfR9rpx5kB3P7H5jx7A/l+/Coxv7UpO+eYtL0jjj9NN5KxwM+GJ/7i+z0qkFrI4nM/uyvrn40lQ/m/mMflMZ1/mtEY+A6R26C0iKH5/tx+L1L77tXL8E0GNEoRQGMBOh92JCFitYhLdnCi+vrc1m4zlMjyDUS+Fzgp6nolwiIq3kGP4cNfUqWTbtqYoro/QBoDHVKFlp8cG3fbu21DhGQD2+fvmpeXO+3np3SoSZq8ImiWztKHzuoaXfPIyT71C6BHpLDJsrzx5i/xjPi7vMP/wAAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The merchant information. The merchant is also known as the payee. Appears to the customer in checkout, transactions, email receipts, and transaction history.
    /// </summary>
    [DataContract]
    public class PayeeDisplayable
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public PayeeDisplayable()
        {
        }

        /// <summary>
        /// The name of the merchant. Appears to the customer in checkout, payment transactions, email receipts, and transaction history.
        /// </summary>
        [DataMember(Name = "brand_name", EmitDefaultValue = false)]
        public string BrandName { get; set; } = null!;

        /// <summary>
        /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [DataMember(Name = "business_phone", EmitDefaultValue = false)]
        public Phone BusinessPhone { get; set; } = null!;

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [DataMember(Name = "business_email", EmitDefaultValue = false)]
        public string Email { get; set; } = null!;
    }
}
