// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// Money.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/6yT32vUQBDH3/0rhn1SyDXnDxDurbQIKrZFD0HOYud2J5fBzW6cna0E6f8uSS7X3l1BCj6Fmd358f3ku3/MsmvJLMynGKgzhfmKwrj2dIFNnzaF+UjdfXBOyQq3yjGYhVnWBDaLULAdYHCATcxBoYoCCBUHDJbRgwqGhLavKiBlWwMmQFijx2AJokCLXUNBwWU6MYU5FcFu3GxemM+E7jL4ziwq9In6xK/MQm6XuJLYkihTMovVTlNS4bA5FjWt/MNGR3sKD0+O5a60FqKZrVHQKgm8/3I5e/Pq5dt7EH3t9fPSRZtKDkobwb5B6VjIaimUtJwuz/rLqXwBWqMCOwrKFVMCfYD2SURU8gGQkL2/K/5J5RZ93qcxZY4pDCcF/K7Z1tDwplZY0+J7ns9f2+yHL42R5zE6DTCwIBncsZXWK/X8k+Dmw9W3mxECCkGICtq1bNH7DioZvYP+ZGxaTl0PZoAjyw36XcXjs5YX5w9mpbx2fMuOXL9hBK1jThic1unxceWk8F2U4T/JFj6E3KxJIFa7RVqPltL2Qew5pIBEBKuzKXfWG+Gptvkfzri+e/YXAAD//w==
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Payments
{
    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [DataContract]
    public class Money
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Money()
        {
        }

        /// <summary>
        /// REQUIRED
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
        /// </summary>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The value, which might be:<ul><li>An integer for currencies like `JPY` that are not typically fractional.</li><li>A decimal fraction for currencies like `TND` that are subdivided into thousandths.</li></ul>For the required number of decimal places for a currency code, see [Currency Codes](/docs/integration/direct/rest/currency-codes/).
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; } = null!;
    }
}
