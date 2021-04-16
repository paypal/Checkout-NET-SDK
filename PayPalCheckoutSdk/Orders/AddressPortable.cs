// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// AddressPortable.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
    /// </summary>
    [DataContract]
    public class AddressPortable
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public AddressPortable()
        {
        }

        /// <summary>
        /// The non-portable additional address details that are sometimes needed for compliance, risk, or other scenarios where fine-grain address information might be needed. Not portable with common third party and open source. Redundant with core fields.<br/>For example, `address_portable.address_line_1` is usually a combination of `address_details.street_number`, `street_name`, and `street_type`.
        /// </summary>
        [DataMember(Name = "address_details", EmitDefaultValue = false)]
        public AddressDetails AddressDetails { get; set; } = null!;

        /// <summary>
        /// The first line of the address. For example, number or street. For example, `173 Drury Lane`. Required for data entry and compliance and risk checks. Must contain the full address.
        /// </summary>
        [DataMember(Name = "address_line_1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; } = null!;

        /// <summary>
        /// The second line of the address. For example, suite or apartment number.
        /// </summary>
        [DataMember(Name = "address_line_2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; } = null!;

        /// <summary>
        /// The third line of the address, if needed. For example, a street complement for Brazil, direction text, such as `next to Walmart`, or a landmark in an Indian address.
        /// </summary>
        [DataMember(Name = "address_line_3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; } = null!;

        /// <summary>
        /// The highest level sub-division in a country, which is usually a province, state, or ISO-3166-2 subdivision. Format for postal delivery. For example, `CA` and not `California`. Value, by country, is:<ul><li>UK. A county.</li><li>US. A state.</li><li>Canada. A province.</li><li>Japan. A prefecture.</li><li>Switzerland. A kanton.</li></ul>
        /// </summary>
        [DataMember(Name = "admin_area_1", EmitDefaultValue = false)]
        public string AdminArea1 { get; set; } = null!;

        /// <summary>
        /// A city, town, or village. Smaller than `admin_area_level_1`.
        /// </summary>
        [DataMember(Name = "admin_area_2", EmitDefaultValue = false)]
        public string AdminArea2 { get; set; } = null!;

        /// <summary>
        /// A sub-locality, suburb, neighborhood, or district. Smaller than `admin_area_level_2`. Value is:<ul><li>Brazil. Suburb, bairro, or neighborhood.</li><li>India. Sub-locality or district. Street name information is not always available but a sub-locality or district can be a very small area.</li></ul>
        /// </summary>
        [DataMember(Name = "admin_area_3", EmitDefaultValue = false)]
        public string AdminArea3 { get; set; } = null!;

        /// <summary>
        /// The neighborhood, ward, or district. Smaller than `admin_area_level_3` or `sub_locality`. Value is:<ul><li>The postal sorting code for Guernsey and many French territories, such as French Guiana.</li><li>The fine-grained administrative levels in China.</li></ul>
        /// </summary>
        [DataMember(Name = "admin_area_4", EmitDefaultValue = false)]
        public string AdminArea4 { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The [two-character ISO 3166-1 code](/docs/integration/direct/rest/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [DataMember(Name = "country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; } = null!;

        /// <summary>
        /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent. See [postal code](https://en.wikipedia.org/wiki/Postal_code).
        /// </summary>
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; } = null!;
    }
}
