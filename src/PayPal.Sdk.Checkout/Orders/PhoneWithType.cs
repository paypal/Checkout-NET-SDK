// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// PhoneWithType.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/9xVQYucTBC9f7+i6NMMuOO3kOTgLbh7CkyWzZDLMgyt1mhBW226SyYS9r+HVmOYcSQJCUvITeu9qnr9qmy/qF3XoEpUU1nGw4mkOkiIROqjdqQzg1tdXye8w27EVKTu0OeOGiHLKlG7CqFPAOKjdbUO8Y2K1FvndDe0/D9Sj6iL92w6lRy18RgCn1pyWEyBB2cbdELoVfI0iX0IpZckcltn6M70XQBLWgdCBMRA4iHXbJlybYBY0HF/CG3g6X5z++bVyCYuoTGaYTjmflWJND6J49PptCFpN8QSO8zj3c3jfXrTp8bI618yQ1y76IWXoGFuRm5bFtcdcm0McXnIbXE+tIkwAHNTRgKMFSAQYZWm6xdyCAYRdUaMBRjkUiqwR5AKIU1Bc9E/Tl2HdlC3XoCtQIZQOtSCDqTSDLevoaCSxA+VL/Nyy568+NBCf0cL9ELD2+jA9i5d9919mwXPQvJYY/Vhu/7dNefWmOfoh/PFz4LsyfK1hb8Czuc7kUb1LyT8m7PXdM+xueyLuf0Fy7j4ofwbOzq/ffpJ739i1sPFO/tfnIWXbuMA/5GV3D//9xUAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The phone information.
    /// </summary>
    [DataContract]
    public class PhoneWithType
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public PhoneWithType()
        {
        }

        /// <summary>
        /// REQUIRED
        /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [DataMember(Name = "phone_number", EmitDefaultValue = false)]
        public Phone PhoneNumber { get; set; } = null!;

        /// <summary>
        /// The phone type.
        /// </summary>
        [DataMember(Name = "phone_type", EmitDefaultValue = false)]
        public string PhoneType { get; set; } = null!;
    }
}
