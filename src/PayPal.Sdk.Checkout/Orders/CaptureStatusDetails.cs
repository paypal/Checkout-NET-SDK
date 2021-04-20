// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// CaptureStatusDetails.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6SPQUvDQBBG7/6KYc5BPOcmJEgRYpHiRaQZm6kZ2O6uMxNkkf53kYSAFHrx+uYxvO8bdyUz1nig7JPy3px8sv3AThIMK3whFXoP3NHpqvfIZVGwwobtoJJdUsQadyPDIkI6go8My5sBMpUTR4f53y1WeK9KZa66q/CZaXiKoWB9pGD8Cz4nUR5WsNWUWV3YsH5d95irxI/LfmWyFP/0ruiyej7B11iuVYMY9Nu2azbdQw9JoW/abtM2/X/nxCmE89v55gcAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The details of the captured payment status.
    /// </summary>
    [DataContract]
    public class CaptureStatusDetails
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public CaptureStatusDetails()
        {
        }

        /// <summary>
        /// The reason why the captured payment status is `PENDING` or `DENIED`.
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; } = null!;
    }
}
