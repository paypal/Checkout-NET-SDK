using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    [DataContract]
    public enum ESellerProtectionStatus : byte
    {
        /// <summary>
        /// Your PayPal balance remains intact if the customer claims that they did not receive an item or the account holder claims that they did not authorize the payment.
        /// </summary>
        [EnumMember(Value = "ELIGIBLE")]
        Eligible,

        /// <summary>
        /// Your PayPal balance remains intact if the customer claims that they did not receive an item.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_ELIGIBLE")]
        PartiallyEligible,

        /// <summary>
        /// This transaction is not eligible for seller protection.
        /// </summary>
        [EnumMember(Value = "NOT_ELIGIBLE")]
        NotEligible,
    }
}
