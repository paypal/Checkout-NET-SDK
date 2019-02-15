// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Card.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The payment card to use to fund a payment. Can be a credit or debit card.
    /// </summary>
    [DataContract]
    public class Card
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Card() {}

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue = false)]
        public PortablePostalAddress(MediumGrained) BillingAddress;

        /// <summary>
        /// The card network or brand. Applies to credit, debit, gift, and payment cards.
        /// </summary>
        [DataMember(Name="card_type", EmitDefaultValue = false)]
        public string CardType;

        /// <summary>
        /// REQUIRED
        /// The year and month, in ISO-8601 `YYYY-MM` date format. See [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="expiry", EmitDefaultValue = false)]
        public string Expiry;

        /// <summary>
        /// The PayPal-generated ID for the card.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id;

        /// <summary>
        /// The last digits of the payment card.
        /// </summary>
        [DataMember(Name="last_digits", EmitDefaultValue = false)]
        public string LastDigits;

        /// <summary>
        /// The card holder's name as it appears on the card.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name;

        /// <summary>
        /// REQUIRED
        /// The primary account number (PAN) for the payment card.
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number;

        /// <summary>
        /// The three- or four-digit security code of the card. Also known as the CVV, CVC, CVN, CVE, or CID.
        /// </summary>
        [DataMember(Name="security_code", EmitDefaultValue = false)]
        public string SecurityCode;
    }
}

