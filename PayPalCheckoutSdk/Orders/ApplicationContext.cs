// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// ApplicationContext.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/7xYT4/buhG/91MQ7qUL2FaySVNkb8Emh6Btski3vaQLY5YaScRSJDNDreMU+e4FSUnWv33Jw3N8saHhkJzf/OPM/G91e3C4ulq9cU4rCV5ZI66t8fjVr9ar/wApuNf4AerAtFqv/o6H48dbZEnKhU2rq9V1w97W6huy8BUKBwckgV8dkkIjUeQNKVPGNXCO7CNo4chKZBaFpW5TjcaLvfKVuIHDDejtf5tnz17Ie23lw5fGeozf6VeyJ2vKRPlgPV4lcjakixsgb5BYgMnFP4Ee0DsNElnUqqy8kNYUqmwIRdotbd5eck9g8p2Bur0uOy7Fw6b8XCnnlCl3jrBACrDnG1s9uCSVACltY7xg9I1bi32lZCXsIxKpvFUl4ZcG2YtH0A1yq5BsqpHVevWGCA7Jos/Wq08I+UejD6urAjRjIHxpFGHeE27IOiSvkFdXn3tfYB8EnJv/qI2RI4zIY5e4rVBouEctfAV+guq+YWWC8cNWoUwkJpv3SrEjKiuP2z8I0zRaf1//EKsEI1HvGtIjrCPyHOu/P/1D7CskjFLLGBBIQrEgzBWh9JgLKDzSmCEdy8MQODHOa61CXHWuHgN9AXXk2k25BviXGSaJYOGu5AASnG+oSxBk80Z6UWi7T7HJDqUqlBxkDU4bQTQc9GRrp9EjCwh6cqCFJzAMMtyx/eURAE6N1JG+537gSNVABwFOBcFz4a3wpMoS+zR3Ytkn5r5pdfuuV+QcDA7XjphG5CVo6eQfm8gaAV3kntVKsgJjcBK4PW0BUvvoBEcULaPwB3euXIPG02HnrDJ+bIkR/Wm5a/SVzVv1V5YxuBt7ID96U9u39kyg2lt3SbgRrtnSGNrNDFaMn86xIqahP4nbSnFIoYJtjV7VyOIeRa6K+AQHJUB6RqJCRVSoUEWnMDBluKFCRaJWJh8WKrJC+WCb5Bvn0lyKsF24cqy38cLTsRkd+YwOHBS5OyaEueRPMMwRRJMMasaIpCsOT59LIr67n0CojMcyvWQ7IK8KkONYfYJhjPB9jsarQiH1mNgWfg+xYADfvQsVcLDlo8qT66MJokT+wT1ndsdQwS66Y7swMebBhSegGGUgkBKdD7WOYKubs1pQg8ljZQ7lGMZkYe6TIZACkpZRBMaYYSu7XyhQo2mPlV2bQM5kLG0l6Am+jjRH9lmDKZsIB8q7v1TeO77KMm+t5q1CX2wtlVnla53dS/fyb39mjGG3ubzoHbg/Qpm2d/FWxDvVt+SySGRpQ6ghVL9Jcl4LbmQlgEWNzFAir4VibsJ/LAWbskSO5XK8kkOaj3KGarqGHEXjOv/6/P5fH8WrF683l0dxglceIe33+622clvax4w9mBwo50yxjbsyV7nYoe20Yr91lbtYx4Nt1BboeMPm+V9fX74USYljjYXjG6PCEVFlim1kjoeGM3kbtHiRsHUib148f/VKgHYVbC5FbHjo0Aqe5VZyNoj2LPUPGSH7rOXdBF7OLk7sXLP3+WRP++2w6QmqqJHCA+wHRUrXOPOvLxQdHBDbXj2cMkEyWZtD6aTf9Gw9DrYNnQDDzxdbSDtGHTvMGY7R0tMW2XRc08qyTXK9sU7Wh9/9jkLS2wc0i87WrcyRhfihEL+pb92UaJBiGop7zmQdQt+Qmc0SRuTTzRLSbA1/5TDhKaAL468R4uX1OfSOb5AN2sFeo4fTP63S11vFTsMhQe43Q54TMsfee6CgbnzWbR4f9S6WWjxWaeg+KhsaKzD9sQujqd88+RMGtUk/ObsgW6cmpB+OthcM2pDWjJvp3HT5xqzT0hmr//RKz4v+nj4ZEXUjVxYg5qPca2u8Mg0uTXMtLWy4gYP4YPdL/Kdv4e6+/+n/AAAA//8=
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// Customizes the payer experience during the approval process for the payment with PayPal.<blockquote><strong>Note:</strong> Partners and Marketplaces might configure <code>brand_name</code> and <code>shipping_preference</code> during partner account setup, which overrides the request values.</blockquote>
    /// </summary>
    [DataContract]
    public class ApplicationContext
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public ApplicationContext()
        {
        }

        /// <summary>
        /// The label that overrides the business name in the PayPal account on the PayPal site.
        /// </summary>
        [DataMember(Name = "brand_name", EmitDefaultValue = false)]
        public string BrandName { get; set; } = null!;

        /// <summary>
        /// The URL where the customer is redirected after the customer cancels the payment.
        /// </summary>
        [DataMember(Name = "cancel_url", EmitDefaultValue = false)]
        public string CancelUrl { get; set; } = null!;

        /// <summary>
        /// The type of landing page to show on the PayPal site for customer checkout.
        /// </summary>
        [DataMember(Name = "landing_page", EmitDefaultValue = false)]
        public string LandingPage { get; set; } = null!;

        /// <summary>
        /// The [language tag](https://tools.ietf.org/html/bcp47#section-2) for the language in which to localize the error-related strings, such as messages, issues, and suggested actions. The tag is made up of the [ISO 639-2 language code](https://www.loc.gov/standards/iso639-2/php/code_list.php), the optional [ISO-15924 script tag](https://www.unicode.org/iso15924/codelists.html), and the [ISO-3166 alpha-2 country code](/docs/integration/direct/rest/country-codes/).
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; } = null!;

        /// <summary>
        /// The customer and merchant payment preferences.
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public PaymentMethod PaymentMethod { get; set; } = null!;

        /// <summary>
        /// The internal client-generated token.
        /// </summary>
        [DataMember(Name = "payment_token", EmitDefaultValue = false)]
        public string PaymentToken { get; set; } = null!;

        /// <summary>
        /// The URL where the customer is redirected after the customer approves the payment.
        /// </summary>
        [DataMember(Name = "return_url", EmitDefaultValue = false)]
        public string ReturnUrl { get; set; } = null!;

        /// <summary>
        /// The shipping preference:<ul><li>Displays the shipping address to the customer.</li><li>Enables the customer to choose an address on the PayPal site.</li><li>Restricts the customer from changing the address during the payment-approval process.</li></ul>
        /// </summary>
        [DataMember(Name = "shipping_preference", EmitDefaultValue = false)]
        public string ShippingPreference { get; set; } = null!;

        /// <summary>
        /// Configures a <strong>Continue</strong> or <strong>Pay Now</strong> checkout flow.
        /// </summary>
        [DataMember(Name = "user_action", EmitDefaultValue = false)]
        public string UserAction { get; set; } = null!;
    }
}
