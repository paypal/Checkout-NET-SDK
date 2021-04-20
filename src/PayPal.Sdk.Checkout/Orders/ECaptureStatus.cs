using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    [DataContract]
    public enum ECaptureStatus : byte
    {
        /// <summary>
        /// The order was created with the specified context.
        /// </summary>
        [EnumMember(Value = "CREATED")]
        Created,

        /// <summary>
        /// The order was saved and persisted. The order status continues to be in progress until a capture is made with final_capture = true for all purchase units within the order.
        /// </summary>
        [EnumMember(Value = "SAVED")]
        Saved,

        /// <summary>
        /// The customer approved the payment through the PayPal wallet or another form of guest or unbranded payment. For example, a card, bank account, or so on.
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        Approved,

        /// <summary>
        /// All purchase units in the order are voided.
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        Voided,

        /// <summary>
        /// The payment was authorized or the authorized payment was captured for the order.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,

        /// <summary>
        /// The order requires an action from the payer (e.g. 3DS authentication). Redirect the payer to the "rel":"payer-action" HATEOAS link returned as part of the response prior to authorizing or capturing the order.
        /// </summary>
        [EnumMember(Value = "PAYER_ACTION_REQUIRED")]
        PayerActionRequired,
    }
}
