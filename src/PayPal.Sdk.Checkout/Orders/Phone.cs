// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Phone.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/9xTwWrbQBC99yuGPdmgWA20PehWlJwKbkhNLyGYkTSWBlaz6u4IV5T8e1lLVUjk0kPBlN60M/PmvX1v9cPsho5MZu4aJ2QS8xU9Y2Fpi20sm8R8ouH5cEOh9NwpOzGZ2TUEXQSC9G1BPgEWYA1QojjhEi2wKHnBCEALD7eb6w/vpmmWGjqLAgfnW9THVaPahSxNj8fjhrXfsGjqqUx3V/e3+dUJmpKsNyYxH73HYZT+NjH3hNVnsYPJDmgDxcK3nj1Vc+HOu468MgWTPcyXDhpFLG9dul7UD/sSrWWp96Wr6IUT88DYWLoyDcC0AeIgrPJ8fSGLYBTRFixUgSWptQF3AG0I8hxQqtPnzDrSQdsHBXEKBUHtCZU8aIMC1++h4po1jJtf40ongYOGSIHP3YqC8niaHNje5OsTe+iL6FkETztWX7Z/Ha301j4lf8yXvitJYCf7kftFtmeay3znoUn9hYT/cvac7mVvKftVbv/AY/ztj/J/vFH1/bmkH5/e/AQAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
    /// </summary>
    [DataContract]
    public class Phone
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Phone()
        {
        }

        /// <summary>
        /// The country calling code (CC), in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). The combined length of the CC and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and subscriber number (SN).
        /// </summary>
        [DataMember(Name = "country_code", EmitDefaultValue = false)]
        public string CountryCallingCode { get; set; } = null!;

        /// <summary>
        /// The extension number.
        /// </summary>
        [DataMember(Name = "extension_number", EmitDefaultValue = false)]
        public string ExtensionNumber { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The national number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). The combined length of the country calling code (CC) and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and subscriber number (SN).
        /// </summary>
        [DataMember(Name = "national_number", EmitDefaultValue = false)]
        public string NationalNumber { get; set; } = null!;
    }
}
