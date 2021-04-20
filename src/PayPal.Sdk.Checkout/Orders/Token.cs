// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Token.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6zQwUoDMRCA4btPMcw5iue9CXspgi5SvIiHsZntBrNJnEwOUfruktrWahERPOafQL7JGy5rYuxQ4zMHNHhP4ujJ8w3Nx/ma666gwZ7zSlxSFwN2uJwYttfcK1tIVGcOCjkWWbUBjCVYoP3gAg1eiVD9ePfS4B2TvQ2+YjeSz9zCS3HC9hAGiYlFHWfsHg7irOLC+pTs7Bfv9ngqHqgO5M/XHFhI2cKihzEK6H6bP0FVyjdnKN5vzK9YbeNj7i78+MXUEsysU7SgEyl8rtDsi/4/4I+bs3cAAAD//w==
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The tokenized payment source to fund a payment.
    /// </summary>
    [DataContract]
    public class Token
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Token()
        {
        }

        /// <summary>
        /// REQUIRED
        /// The PayPal-generated ID for the token.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The tokenization method that generated the ID.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; } = null!;
    }
}
