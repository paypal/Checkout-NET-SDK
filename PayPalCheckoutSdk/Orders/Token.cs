// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Token.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6yQTUsEMQyG7/6KkHMVz3MT5rIIOsjiRTzEbWan2GnHNEWq7H+Xrs76MYgIe8zzEvK8ecV1mRgbXMdHDmjwlsTRg+crGitGg5dcPoeW00bcpC6GujQwaF10L2xhojJyUEgxy6YG0OdggebgDA1eiFB5P3lu8IbJXgdfsOnJJ67gKTthewCdxIlFHSds7g6yScWF7dLW2W+++3Fp3FHpyJ9uObCQsoVVC30U0LnNv0RV8g/PkL3fmT9ltcZfdT/Ary+mimBkHaIFHUjhmRLkxLb+eq6zr7Fqj9HhfnfyBgAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The tokenized payment source to fund a payment.
    /// </summary>
    [DataContract]
    public class Token
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Token() {}

        /// <summary>
        /// REQUIRED
        /// The PayPal-generated ID for the token.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id;

        /// <summary>
        /// REQUIRED
        /// The tokenization method that was used to generate the ID.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type;
    }
}

