using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    [DataContract]
    public enum EAuthorizationStatus : byte
    {
        /// <summary>
        /// The authorized payment is created. No captured payments have been made for this authorized payment.
        /// </summary>
        [EnumMember(Value = "CREATED")]
        Created,

        /// <summary>
        /// The authorized payment has one or more captures against it. The sum of these captured payments is greater than the amount of the original authorized payment.
        /// </summary>
        [EnumMember(Value = "CAPTURED")]
        Captured,

        /// <summary>
        /// PayPal cannot authorize funds for this authorized payment.
        /// </summary>
        [EnumMember(Value = "DENIED")]
        Denied,

        /// <summary>
        /// The authorized payment has expired.
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        Expired,

        /// <summary>
        /// A captured payment was made for the authorized payment for an amount that is less than the amount of the original authorized payment.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_CAPTURED")]
        PartiallyCaptured,

        /// <summary>
        /// The payment which was authorized for an amount that is less than the originally requested amount.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_CREATED")]
        PartiallyCreated,

        /// <summary>
        /// The authorized payment was voided. No more captured payments can be made against this authorized payment.
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        Voided,

        /// <summary>
        /// The created authorization is in pending state. For more information, see status.details.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,
    }
}
