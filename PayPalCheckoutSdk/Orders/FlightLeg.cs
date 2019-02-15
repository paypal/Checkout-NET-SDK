// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// FlightLeg.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/9xVT4/jxBO9/z5Fyb8LKzkOMIBEbiOhESsQrFAEh9EqW7HL7tK0u5uqcrIG7XdHbSczO+OsQGI0B05R+pWr6r3692exHRMVm+LGc+cMfqSuKItfURj3nn7CPmNFWfxA48Of70hr4WQcQ7Epto6gIUP2CrEFcwTt7MxTVxVlcS2C4xzm87L4hbD5Ofix2LTolfLD7wMLNfcPbyQmEmPSYnN7n6CacLiQHIrwAf0OWVIUe5TrElumfsKgjg2VgAoNtRyogf0It6+vt9dvP3NmSTfr9fF4rBgNqyjdOg17zzVmT7p+gx3pOrtYKaHUrkJN71/9W/Zh8P5D+bcS1JknyS7Hf8T/CbAkn/mBHePKkxkJYF3HIRiHbtIDzKEBNxSMWyadinty+kLcGkooNghdLPAl9D9Z4geiDRp9QoMTtBRADUOzQh8DQTYqgQPcvg5GEsimJ8DQgHFP0Ebp0R4ksRi9VkzWTqI46/1a2vrq6urb/yvVOczq6+qbVxVsIwglIaVgoIlqRp+XAHo4oB9IS9ChdrkCOAeNLexZzJUwxgHUxcE3MOicpcKRzUGIgKqxZjQ6pRhl+l39cSKEFfzmKNCBBFJU5b2ncvJjZ/YoDbzLXnf5y3dgY6IKto4VhLrBowC9z7krxwBNJIUQLefNszzez0lVcBOzLfYpB7mhvQwoI1x9Aayz/aRliObyHLHCXYjHALiPQ96JmGAkFH3xzsnEP9E5J2jZORmYuiUL6dym7+HLr+B7OXXJC3FoUWi3R2Vd7rgltmQx7bJB54lHFs+BwOJ5s42AkN1MTTEVj0KOfm+qhm07T4jggTxgR8E0u2g5vzoCGTxplgUsN5VxfUfPrQ8Ho47kgkDTwd2Fod9P8EfyPEGW4pyO9WxxvuD1IJKn+BlO+D+ssZIcuKZd7VH1EYWnyIX9NlvAZJGrcnRcu4nIfbWnegCm5JleavbUYoqHS5f5KbLkFAOdr/JHpzg0+SDl1ejIHMnEMaEqhY4kL5vc0ebzpozQ4x0BwjnYs7B+++F/fwEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The details of the flight leg.
    /// </summary>
    [DataContract]
    public class FlightLeg
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FlightLeg() {}

        /// <summary>
        /// The airport code, as defined by [IATA](https://www.iata.org/publications/Pages/code-search.aspx).
        /// </summary>
        [DataMember(Name="arrival_airport", EmitDefaultValue = false)]
        public string ArrivalAirport;

        /// <summary>
        /// The IATA two-letter accounting code that identifies the carrier.
        /// </summary>
        [DataMember(Name="carrier_code", EmitDefaultValue = false)]
        public string CarrierCode;

        /// <summary>
        /// The airport code, as defined by [IATA](https://www.iata.org/publications/Pages/code-search.aspx).
        /// </summary>
        [DataMember(Name="departure_airport", EmitDefaultValue = false)]
        public string DepartureAirport;

        /// <summary>
        /// The stand-alone date, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). To represent special legal values, such as a date of birth, you should use dates with no associated time or time-zone data. Whenever possible, use the standard `date_time` type. This regular expression does not validate all dates. For example, February 31 is valid and nothing is known about leap years.
        /// </summary>
        [DataMember(Name="departure_date", EmitDefaultValue = false)]
        public string DepartureDate;

        /// <summary>
        /// The time, in the hh:mm 24 Hr format.
        /// </summary>
        [DataMember(Name="departure_time", EmitDefaultValue = false)]
        public string DepartureTime;

        /// <summary>
        /// The code used by airline to identify a fare type and enable airline staff and travel agents to find the rules for this ticket.
        /// </summary>
        [DataMember(Name="fare_basis_code", EmitDefaultValue = false)]
        public string FareBasisCode;

        /// <summary>
        /// The flight number of the current leg.
        /// </summary>
        [DataMember(Name="flight_number", EmitDefaultValue = false)]
        public int? FlightNumber;

        /// <summary>
        /// The service class to which the airline ticket applies.
        /// </summary>
        [DataMember(Name="service_class", EmitDefaultValue = false)]
        public string ServiceClass;

        /// <summary>
        /// The one-letter code that indicates whether the passenger is entitled to make a stopover.
        /// </summary>
        [DataMember(Name="stopover_code", EmitDefaultValue = false)]
        public string StopoverCode;
    }
}

