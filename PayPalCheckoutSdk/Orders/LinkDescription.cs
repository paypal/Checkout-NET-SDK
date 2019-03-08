// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// LinkDescription.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+xX32/bRgx+319BqAMWA/4RFG3W+S1bUzRYswSOu5egsGmJtm453al3VBxh2P8+3EmOIitqulYJMEAPfhBJyd9H8nj8/g7meUrBNPgg1DW8JRsakbLQKhgGf6IRuJL0ByYuIhgGv1NePdwPngbzmMDQ54wsjwxJZIrg6v3x/OT8+BKkUNefDiaRDu0EUzHRN2RuBG0nL2Jk0mhHLsIOQKi1Ngm6b46DYXBsDOYFwMNhMCOMzpXMg+kapSVn+JwJQ9Gd4cLolAwLssH06o6aZSPUpkmIVLhgF3KfGKlwXtia/BKKBIJ7BYSCbSzCGFiDzVaJYOAqAxAh4/cSUJmU/wwfZREbWtcYlIYm/FAnqSQmYDQbYvg4+zCGuYYEr6lEX9QtRCmHLnwlVOFJiGMdwVZwDBwLC1cfZ6cwpyR1b4yKojFFnw5i5tROJxPWWtqxIF6PtdlMYk7kxKzDo9c/Hw58P4zhnTaQGhqlRodkrVCbIQgVyiwq/nT543IIy4PlEFBFsBwsIYzRYMhk7Bgco6XjugRhffw15bDrOMdVK1KuLMj+Dy3gXQoKjgUfdAW0rnCKvfk/FY5N9m11883U7D9v/ooOHAJaiGgtFEWwyuFq9u43eHn46qgqwXa7rQpg1qH7uYgx3/JgXB72FRXJcxkqG+OZGrfoqT3ypanJ/P18frFrQ1P+uzt8DzbvMzEwJGvwi+cm9iufXA9QaOXL9+hBef3LmzcvLIXujdGrwbAcN5bMDVlXe1Rw+hbW2gCWxXONnilMVmKT6czKHKJaiS0lqFiEFvT6ruZjuCSCKz/+ZyVCu9dDqNBjQ2vFRiWk2E7cu6Mdpf3H8a2jMej2IHmIl2FMCTZLYXf2qhp3ptaLyo9p0KbL5q+uHb36i0JuQsUoEg4LyoVgSmwNdOU8LX119McqhyoG/Ac67naUcqHXHtsD4L2zDlnK8/UDQAEdJtdrNluNimqUc9vnPcksww1KESET4AaFsgxuLN+Pr3M7+l5uKv8CN++sc1N5h9y0ItdtiTb0hBzb+s5fFr5x6i1Xt9eZdttZ7chSUhGp0L1Uh1ZzPCW2thm/NrhxE29hyGqZlatxBXHnn913NyfOLgyqz4yfJ7nNGSNaJoufJh2jcpO1icmvYzVMO0v7QfMRHR+VM7dOtaxmza3sMU3gttRQK6ZbHpEKdSTUBvwZp6cXMyuh0OSL3f/W0Be+k8r1kDZQTKqJu9gOzjLJIs1Mqi3BqWIyihjOUEg4uWVS1g0PODg7PTsZwAUahnNFU7fgJ8iueNU7ZC1uCH7VkSD76Bb08vDV68EzbXONVZwf38K/OT/zrZ6Cbz9wsL4qE0fdZOLTVwwNpbmWiuL5Se8GRe03c+GsIdKKOr6Zq/iOp0xbw6XI8cIymnqunfmytO71ngZMU5kXErzA6jSQ2+UdDVQh2Z/g4+zUDsF/2Lvc8z3pfoMyo2e6fFJkdxgWafXqHlXnvrjvbR63MgqqjzwX+hbU7XC7Pp9f1DyFYLlsKp89R69/ev3T659e//T6p9c/vf7p9U+vf3r90+ufXv/8D/RP66wSLPeGVWlppq8QN87d0fj44V8AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The request-related [HATEOAS link](/docs/api/overview/#hateoas-links) information.
    /// </summary>
    [DataContract]
    public class LinkDescription
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public LinkDescription() {}

        /// <summary>
        /// The media type in which to submit the request data.
        /// </summary>
        [DataMember(Name="encType", EmitDefaultValue = false)]
        public string EncType;

        /// <summary>
        /// REQUIRED
        /// The complete target URL. To make the related call, combine the method with this [URI Template-formatted](https://tools.ietf.org/html/rfc6570) link. For pre-processing, include the `$`, `(`, and `)` characters. The `href` is the key HATEOAS component that links a completed call with a subsequent call.
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue = false)]
        public string Href;

        /// <summary>
        /// The media type, as defined by [RFC 2046](https://www.ietf.org/rfc/rfc2046.txt). Describes the link target.
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue = false)]
        public string MediaType;

        /// <summary>
        /// The HTTP method required to make the related call.
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue = false)]
        public string Method;

        /// <summary>
        /// REQUIRED
        /// The [link relation type](https://tools.ietf.org/html/rfc5988#section-4), which serves as an ID for a link that unambiguously describes the semantics of the link. See [Link Relations](https://www.iana.org/assignments/link-relations/link-relations.xhtml).
        /// </summary>
        [DataMember(Name="rel", EmitDefaultValue = false)]
        public string Rel;

        /// <summary>
        /// The request data or link target.
        /// </summary>
        [DataMember(Name="schema", EmitDefaultValue = false)]
        public LinkSchema<T> Schema;

        /// <summary>
        /// The request data or link target.
        /// </summary>
        [DataMember(Name="targetSchema", EmitDefaultValue = false)]
        public LinkSchema<T> TargetSchema;

        /// <summary>
        /// The link title.
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue = false)]
        public string Title;
    }
}

