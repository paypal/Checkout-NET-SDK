// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// LinkSchema.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/7yVz0/bShDH7++vGPnyQAoJenqPQ248lUpRm4KA9oJQNLHH8bbrWbM7Bqyq/3u1mwSzGCNUTI6e7+z6M7Pz42dy2VSUTJPPin/ARVpQicko+YZW4VLTFyy9mIyST9S0Hx/IpVZVogwn0+SyILB0U5MTyFAQjAXtrxO0K5JxMkqOrcVm/afDUXJOmJ2ybpJpjtqRN9zUylL2YDizpiIrilwyvXpgNMvvlEoXD7NMeRbUCyVUugi3FWcbLaY/5gZaHwgXvBWZa61/jR64UeuFyQPbM/BBjJG1Ps2fAQX0TGBycPXywIXHcmPw+Q95L2sncItaZSgEuELFTgC1jvzj2I7eGhs3L8QWxDg2bgaMzTD5aiuNpXeMsa/uMsoVh8KJSy62x5EOW1n9ZBVxRpz6QzFaJLwnmxOreNVlyy2uSmJZWHJG1+HfjxG3+vljuTtxtm7QXjPeTXK7M0b1TJYwTQam8pO1y+StMdPW0t9owWPgVplTpp5ZIOXG3OJtLd2HDQpIUxEgZ5AaFrqXA+LUZIpXEHqchtsqfXW6VIy2WWz/G9GvtZNW6oYRuLnLDRdEcDWvtaiqtpVxBDMWskwCc1QaTu6F2PnhAXvz2fxkH87QCpwyTeGjsSWKf7z2DDmHK4L/TabIXe8VIpWbTiZijHZjRZKPjV1NCin1xObpP4f//rc/3k2n+zeM0rYxvPTmf5yfyzszhVB+4LFelYmjYTJx/YqhwUaiVKy/33U3MPVv5rUYERmmgTdz6z/wlOkruAqlWDhBG+famy821ie1ZwCrSjcghXLrDkUQA1IQ+DCQU3J/w9fzmRtBuDhI/hvulBTrc7eoa9rR8qlQfDMsqvbok1C9fPZY7bbbxgvaS3ZF30PdjztMf/71GwAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The request data or link target.
    /// </summary>
    [DataContract]
    public class LinkSchema<T>
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public LinkSchema() {}

        /// <summary>
        /// Any additional items.
        /// </summary>
        [DataMember(Name="additionalItems", EmitDefaultValue = false)]
        public T AdditionalItems;

        /*
        /// <summary>
        /// An array of sub-schemas. The data must validate against all sub-schemas.
        /// </summary>
        [DataMember(Name="allOf", EmitDefaultValue = false)]
        public List<AllOfItem> AllOf;

        /// <summary>
        /// An array of sub-schemas. The data must validate against one or more sub-schemas.
        /// </summary>
        [DataMember(Name="anyOf", EmitDefaultValue = false)]
        public List<AnyOfItem> AnyOf;
        */

        /// <summary>
        /// </summary>
        [DataMember(Name="definitions", EmitDefaultValue = false)]
        public T Definitions;

        /// <summary>
        /// </summary>
        [DataMember(Name="dependencies", EmitDefaultValue = false)]
        public T Dependencies;

        /// <summary>
        /// The fragment resolution.
        /// </summary>
        [DataMember(Name="fragmentResolution", EmitDefaultValue = false)]
        public string FragmentResolution;

        /// <summary>
        /// An item.
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue = false)]
        public T Items;

        /*
        /// <summary>
        /// An array of links.
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<Link> Links;
        */

        /// <summary>
        /// The media type and context-encoding scheme.
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue = false)]
        public Media Media;

        /// <summary>
        /// </summary>
        [DataMember(Name="not", EmitDefaultValue = false)]
        public T Not;

        /*
        /// <summary>
        /// An array of sub-schemas. The data must validate against one sub-schema.
        /// </summary>
        [DataMember(Name="oneOf", EmitDefaultValue = false)]
        public List<OneOfItem> OneOf;
        */

        /// <summary>
        /// To apply this schema to the instances' URIs, start the URIs with this value.
        /// </summary>
        [DataMember(Name="pathStart", EmitDefaultValue = false)]
        public string PathStart;

        /// <summary>
        /// The pattern properties.
        /// </summary>
        [DataMember(Name="patternProperties", EmitDefaultValue = false)]
        public T PatternProperties;

        /// <summary>
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue = false)]
        public T Properties;
    }
}

