// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// AddressDetails.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/7xVTW/DRBC98ytGPjtuEbfcqlYIASpVVbgAisfecTJivWNmd5NaqP8drT+SukmFqqLe7Jn9eO/Nm9l/sqe+o2yd3Rij5D3cUUC2Psuz31AZK0v32KYFWZ79RP3p5458rdwFFpets6cdgRO36kRD2gRoDKcc2vQ5HG3GoyHsMAAqgZeWArfkwREZMtCIQi1tZxldTTko+79yEAUJO1LwNTlUFg+HHSlBw45WW0V2xzvYNaItppuh5e0uQEXT6QXcS4AjwAOHXbqsFQdhx2qgQw09oDMgHTnwErWmAh7JRGfQhXnLcDNZ44s/4vX1d3WlV8MHfS8K9IxtZymHcoK0mW8s5oBlR5tvS2AP0Ue0tgdMSCp2I3BpTrsn0QoflChsXGwr0jKHcg5gS2U+oJ5Doe+oLLI8u1HFfqzvdZ49EppfnO2zdYPWUwr8HVnJHAMPKh1pYPLZ+vejM3xQdttzQ1SRrWG3HSAs3PE2s7TKDaSwASv1QHcyhFKn5MmF9E/QKbXsqYBfjxLNxw77kytGMWAwjbVUz+LNC/1YMZzLvNxXwKJeYy1rMTQW81ZxTw5+kOjHSH11Sn5WXRetfcn/U2JDlvek/caT7rleqnwhed6T8yKYFhXwID6ANA3XBJU851DhdlJkaLXuVT4J9kVUX9l5wXIZPyc45kek8GP0Aco7jdqXwG76hJ/Rfb4hPshjEPQikznzPpfRnl+KN82MS2in+LtYU/5NI6W2iZRDJdHSHtXkoIJmMBc9pyb3B+y/il6sNvM4WPJbJs4JNqw+rEQNKZALHHqoyMoBcJpfx3EkepxlF0eZj9Xqwjjz7LaWTsekWZVesg8MswJu0aUXDqGxGHLwQbTPobEimmSXdpAd09PWkgv/i+p/vnzzLwAAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The non-portable additional address details that are sometimes needed for compliance, risk, or other scenarios where fine-grain address information might be needed. Not portable with common third party and open source. Redundant with core fields.<br/>For example, `address_portable.address_line_1` is usually a combination of `address_details.street_number`, `street_name`, and `street_type`.
    /// </summary>
    [DataContract]
    public class AddressDetails
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public AddressDetails()
        {
        }

        /// <summary>
        /// A named locations that represents the premise. Usually a building name or number or collection of buildings with a common name or number. For example, <code>Craven House</code>.
        /// </summary>
        [DataMember(Name = "building_name", EmitDefaultValue = false)]
        public string BuildingName { get; set; } = null!;

        /// <summary>
        /// The delivery service. Post office box, bag number, or post office name.
        /// </summary>
        [DataMember(Name = "delivery_service", EmitDefaultValue = false)]
        public string DeliveryService { get; set; } = null!;

        /// <summary>
        /// The street name. Just `Drury` in `Drury Lane`.
        /// </summary>
        [DataMember(Name = "street_name", EmitDefaultValue = false)]
        public string StreetName { get; set; } = null!;

        /// <summary>
        /// The street number.
        /// </summary>
        [DataMember(Name = "street_number", EmitDefaultValue = false)]
        public string StreetNumber { get; set; } = null!;

        /// <summary>
        /// The street type. For example, avenue, boulevard, road, or expressway.
        /// </summary>
        [DataMember(Name = "street_type", EmitDefaultValue = false)]
        public string StreetType { get; set; } = null!;

        /// <summary>
        /// The first-order entity below a named building or location that represents the sub-premise. Usually a single building within a collection of buildings with a common name. Can be a flat, story, floor, room, or apartment.
        /// </summary>
        [DataMember(Name = "sub_building", EmitDefaultValue = false)]
        public string SubBuilding { get; set; } = null!;
    }
}
