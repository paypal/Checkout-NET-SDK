using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    [DataContract]
    public enum ERefundStatus : byte
    {
        /// <summary>
        /// The refund was cancelled.
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        Cancelled,

        /// <summary>
        /// The refund is pending. For more information, see status_details.reason.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// The funds for this transaction were debited to the customer's account.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,
    }
}
