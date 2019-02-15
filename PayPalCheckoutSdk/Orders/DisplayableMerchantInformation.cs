// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// DisplayableMerchantInformation.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/9yVzW7bRhDH732KAU82wFBOGuWgUwM5QIuiapC6vaSGMFyOyIGXs8zuMDJb+N2LJakPWkrrQ+sWvQjY+dgZ/ua/o9+Tm66hZJFcc2gsdphbgh/ImwpF4TvZOF+jspMkTX5Bz9G/wjpmJGnyPXWHwzUF47npgxfJTUVQ7+7hwz0ZTD0B0AYHd+K2AhhAK4IGO6IM3jYNoQ+grreaNqiryQMLmIrMnWs1BfUoAU28OqRANbIFT4a40ZACSnEcARUHdb7LkjR56z12w8dfpckHwuJHsV2y2KANFA2fWvZU7A3vvWvIK1NIFh/32IJ6lvIUTu5RirXEwzGmifkUWHSA2/Sfu0P0RA4NdjWJ/js8pLX2If1rKG1goRDWfVtTMI9dp3BYlLz0IkLLv1Exfh0WhacQsl/bq6uvTW6dufvUOqX+PPyaoN5JOVhWTmkxmGfHdvi5iYjfvAZToUej5AOgJ0Br3ZYKyGnj4lEKeDWffykKN0q+H9RQw7hibOWbsejBAoFLyeBbt6XP5NM+qyQhj9Z2gMZQo1RAjfdctzVYklIr2DgPKNOvjw/p1fy49eGhNaiRGnwmzxum+L5QY3YrPaTiqV0C3XPQHeXZY8x/r4DeV07oT/TTjP4z+tm5TvXTe0DaOo+oWYA1gEFxwgbtVF7w8V328s3rMZqlhMaiwLDFbi8q1SYsZrPtdpuxthmLzjyZ2c2LD++WL/rUGcnlP79mjGtFfbc2aC1LuY5Dm3DZBwyOUypjAIw3QAyEi+Xy8pkQwdBEnbNQsVP4uAKXy2Fh9ZtxrDqUg7oNCuIUcoLSEw5vDgVezqHgknXU/+M84yREHccSePAWFJSH00hgdb287KuHNo/MYvJ4x8VPq8tn2ph0rySBnayH2pPZnnGezncfNHb/TI3vyJ7r+9R37p9wMrf/gBi/+FD+HxpV356b9O3D7cNXfwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The merchant information. The merchant is also known as the payee. Appears to the customer in checkout, transactions, email receipts, and transaction history.
    /// </summary>
    [DataContract]
    public class DisplayableMerchantInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public DisplayableMerchantInformation() {}

        /// <summary>
        /// The name of the merchant. Appears to the customer in checkout, payment transactions, email receipts, and transaction history.
        /// </summary>
        [DataMember(Name="brand_name", EmitDefaultValue = false)]
        public string BrandName;

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [DataMember(Name="business_email", EmitDefaultValue = false)]
        public string BusinessEmail;

        /// <summary>
        /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [DataMember(Name="business_phone", EmitDefaultValue = false)]
        public Phone BusinessPhone;
    }
}

