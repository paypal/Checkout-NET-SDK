// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// AmountWithBreakdown.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+yY22vkNhTG3/tXHPzUgjNOL1AY6EO620JaujvsDoWShMwZ6TgWK0veIylZU/q/F/k29kx6CaQvjd6sI1v69Pk7P2b8e7ZtG8rW2UVtg/HwoHwF3zPhB2kfTJZnvyIr3Gt6g3W8Lcuzn6k9DF6TE6war6zJ1tm2IvDWowbLkhhwtigasN19qGE/bgC+Qg8N23slyYEkj0q7HFwQFaADPy2oPNXDevlQ8vhpqrhKNY0ydzlUaKTurpRxgdEIygGNBKmciDe7HFQJaNrVdTg//1rsuegu6LKE1gZwDQlVtrDr115NYnd5p2c4FH0MqB3sorDbTtAOGh0c7Dx+WhZGceN4lDiOJ6E7qJWZP3E7it4di90elNTBedgTIDTWKa/uCUyo98Qr+NEyaOU8SbAluNA0luNABGYyQpHrrSGhatTQMAnllDU5OKLutBtsN6jh3Q/vt3CxuXTQ60ComMrvrrNCWuEKZTzdMcbXW0jFJHzB5Hwx7NOeCSvJFddZL/7VUIZXsdyvWGA/t8ry7IIZ2z6Y53n2jlC+NbrN1iVqR7HwMSgmORU2bBtir8hl66vjSP9NmvezqUOs59XTfB+ya8tZHlaHfU7yfIjzfxblZzPtF2uoPXVqlLIwalY89Wl89Z3gIamlZUAolUEjVDw2o3EofJ+4wSSEPep4VrAMDbY1GQ8yPGMwnOde9dEhR8m3Ma2Lkx7PnB73yldMdCYqZBSeGC7fvz375qsvvz0YEZ+9+fxJDfNFD0glyXhVxnb1M2uf5IjncGSICVr/kf+jK/eow9KNsXLqQjeTw0OlRAW1uqsimNZ9gwfdN3g/0qofXRjovCDu0jEDk1YfCHY/bX7b9SYgExjrwbeNEqh1CyX32UE90LEYVz3aYwLc+MTje23fvJ7t5cJeqtjHMiq04CsbHBrpK/f4dsV4wkjd+J54MH/AcQTGRFqNgtzQEIuE9Oi9WiLyqbF5jmTczLLxF1SYsLSIx7yauJC4kLjw4rgw/SZegmFeTmRIZEhkeGlkGP/cLNIxKyYqJCokKrxUKkyfux7Fw3w2cSJxInHipXFi+rK+iMe8mriQuJC48D/jws2/SEfqmdQzqWcOPfPZnwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.<br/>If you specify `amount.breakdown`, the amount equals `item_total` plus `tax_total` plus `shipping` plus `handling` plus `insurance` minus `shipping_discount`.<br/>The amount must be a positive number. For listed of supported currencies and decimal precision, see the PayPal REST APIs <a href="/docs/integration/direct/rest/currency-codes/">Currency Codes</a>.
    /// </summary>
    [DataContract]
    public class AmountWithBreakdown
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AmountWithBreakdown() {}

        /// <summary>
        /// The breakdown of the amount. Breakdown provides details such as total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.
        /// </summary>
        [DataMember(Name="breakdown", EmitDefaultValue = false)]
        public AmountBreakdown Breakdown;

        /// <summary>
        /// REQUIRED
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
        /// </summary>
        [DataMember(Name="currency_code", EmitDefaultValue = false)]
        public string CurrencyCode;

        /// <summary>
        /// REQUIRED
        /// The value, which might be:<ul><li>An integer for currencies like `JPY` that are not typically fractional.</li><li>A decimal fraction for currencies like `TND` that are subdivided into thousandths.</li></ul>For the required number of decimal places for a currency code, see [Currency Codes](/docs/integration/direct/rest/currency-codes/).
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue = false)]
        public string Value;
    }
}

