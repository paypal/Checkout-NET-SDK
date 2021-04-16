// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// PaymentMethod.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6zRT0sDMRAF8LufIsw5Fc97E7wJKlK8iCwx++oG8s/J7CFIv7uUbUOlK/Sw17xh8n7MD21rBnWUTQ2I0gfImAbS9GbYmU+PJxMW80fUY0SaHlAsuywuRepoO0LZqUgKYGXioALYjiaKOm5RmbEDI1qUW9J0z2zqXORO0yvM8Bx9pW5nfMHh4XtyjKE9vHDKYHEo1L03QhF28WuxOtDPXx62nHe/zC4pp/abNtYcJU28giFO3u/1VRDuCzysLDj+RP9fZHOaaor5pipFJWdcVZxgFdnH/uYXAAD//w==
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The customer and merchant payment preferences.
    /// </summary>
    [DataContract]
    public class PaymentMethod
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public PaymentMethod()
        {
        }

        /// <summary>
        /// The merchant-preferred payment sources.
        /// </summary>
        [DataMember(Name = "payee_preferred", EmitDefaultValue = false)]
        public string PayeePreferred { get; set; } = null!;

        /// <summary>
        /// The customer-selected payment method on the merchant site.
        /// </summary>
        [DataMember(Name = "payer_selected", EmitDefaultValue = false)]
        public string PayerSelected { get; set; } = null!;
    }
}
