// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Media.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6ySQUvzQBCG79+vGPbUQr6miHrITbFCkdiixUspsk0mycJmdp2dYIP0v0tabS0FFfW47zDMs8/Mi5q1HlWiUsyNVpF60Gz00uKtrrtYReoG2/3jCkPGxotxpBI1qxDqrhGk9QiacsgcCa7kP1LmckMlhKzCGgcqUhfMut2OG0bqDnU+IduqpNA2YBc8NYYx3wVTdh5ZDAaVzHegQdhQeUy6NKS5fXyfewC+rY32peNvbLjpmBvuEWGeNlaMb9i7gDAmQSYUSLWxMFoJUjCOAvTScTrqw1SzwIQwgWvHtRZwxYceDEGXCJcuNxgWvUrEhySOxTkbBgalGDgu40pqG3ORnQxPz/q/lUeNtevoS4PdDg+0vQWf7fzHfmbPLoHN0UGH9S0T539jYrH+9woAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The media type and context-encoding scheme.
    /// </summary>
    [DataContract]
    public class Media
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Media() {}

        /// <summary>
        /// The content-encoding scheme. See [Multipurpose Internet Mail Extensions (MIME) Part One: Format of Internet Message Bodies](https://tools.ietf.org/html/rfc2045).
        /// </summary>
        [DataMember(Name="binaryEncoding", EmitDefaultValue = false)]
        public string BinaryEncoding;

        /// <summary>
        /// The media type. See [Multipurpose Internet Mail Extensions (MIME) Part Two: Media Types](https://tools.ietf.org/html/rfc2046).
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type;
    }
}

