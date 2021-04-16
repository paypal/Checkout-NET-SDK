// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Payer.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The customer who approves and pays for the order. The customer is also known as the payer.
    /// </summary>
    [DataContract]
    public class Payer
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Payer()
        {
        }

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public AddressPortable AddressPortable { get; set; } = null!;

        /// <summary>
        /// The stand-alone date, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). To represent special legal values, such as a date of birth, you should use dates with no associated time or time-zone data. Whenever possible, use the standard `date_time` type. This regular expression does not validate all dates. For example, February 31 is valid and nothing is known about leap years.
        /// </summary>
        [DataMember(Name = "birth_date", EmitDefaultValue = false)]
        public string BirthDate { get; set; } = null!;

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [DataMember(Name = "email_address", EmitDefaultValue = false)]
        public string Email { get; set; } = null!;

        /// <summary>
        /// The name of the party.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Name Name { get; set; } = null!;

        /// <summary>
        /// The PayPal payer ID, which is a masked version of the PayPal account number intended for use with third parties. The account number is reversibly encrypted and a proprietary variant of Base32 is used to encode the result.
        /// </summary>
        [DataMember(Name = "payer_id", EmitDefaultValue = false)]
        public string PayerId { get; set; } = null!;

        /// <summary>
        /// The phone information.
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public PhoneWithType PhoneWithType { get; set; } = null!;

        /// <summary>
        /// The tax ID of the customer. The customer is also known as the payer. Both `tax_id` and `tax_id_type` are required.
        /// </summary>
        [DataMember(Name = "tax_info", EmitDefaultValue = false)]
        public TaxInfo TaxInfo { get; set; } = null!;
    }
}
