// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// PhoneWithType.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/9xVwWrbQBC99yuGPdmg2A20PehWlJwKbkhNewjGrKSxNLCaVXdHuKLk38tqVQdbNm1pCSU378zbeW/fjEff1bpvUaXqrraM8IWkhiGSqM/akc4NrnQTACpRH7B/OtygLxy1QpZVqtY1QjuUIN5Z1+gQX6hEvXdO95HjdaLuUZcf2fQq3WnjMQS+duSwPATunG3RCaFX6cOxuqmmgXHLXZOjO9J3krikNQISIAYSD4Vmy1RoA8SCjodHaAMPt4vrd29GNHEFrdEM8ZmbWS3S+nS53O/3C5JuQSxLh8VyfXV/m10NV5fI8z8yQ1x30QsvQcPUjMJ2LK7fFtoY4mpb2BKPTDkAYmJqygiAsQIEIMyybP5MDkEU0eTEWIJBrqQGuwOpEbIMNJfDzwNrpIOm8wJsBXKEyqEWdCC1Zrh+CyVVJD5WPr1XWPbkxQcK/ZQt0QvF0+jA6iabD+y+y4Nn4fJYY/ZpNf/bMefOmMfkl/3Fb4LsyfK5gT+TnPb3ABrVP5Pwn86e0z3NTWWf9O0/GMaLf5SXMaPT7TN0evMbvY6LV+IX5HQfj+FL2zik/8lIbh5f/QAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
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
        public PhoneWithType() {}

        /// <summary>
        /// REQUIRED
        /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [DataMember(Name="phone_number", EmitDefaultValue = false)]
        public Phone PhoneNumber;

        /// <summary>
        /// The phone type.
        /// </summary>
        [DataMember(Name="phone_type", EmitDefaultValue = false)]
        public string PhoneType;
    }
}

