// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// LinkDescription.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/+xXQW/bRhO9f79iwHxALYCSjCBxU93cxkGMxnUgK70YBjQiR+LWy1lmd2iZKPrfiyUpSxStOE0k58KDDpxdiu/NvJ2d93cwKTIKRsEHxbfwllxkVSbKcBAGf6JVONP0B6Z+RxAGv1OxftjcPAomCYGlzzk56VvSKBTD9fvTydnl6RVoxbc3R8PYRG6ImRqaO7J3ipbDFwkKGXR9v8P1QPHc2BT9fw6CMDi1FosK4HEYjAnjS9ZFMJqjduQDn3NlKX4IfLQmIyuKXDC6fqDmxCpetAkRR+WOTV7rWJteSrFCkCIjUAzLREUJiAGXz1IlIOsEQIyC34ufc63/CZ8kkViaNxjUgTb8yKSZJiEQtAsS+DT+MICJgRRvqUZflS1CrUO/faa4WklJEhPDUkkCkigH15/G5zChNPNv9KuaCcU3R4lI5kbDoRij3UCRzAfGLoaJpHpo59HJ65+Pe6UcBvDOWMgs9TNrInJO8SIExZHO4+qj0/9PQ5geTUNAjmHam0KUoMVIyLoBeEZTz3UKypX7b6mAleA8V8PEviwo5Qcd4EMKKo4VH/QFdL5wLGX4PxVObP5tdSvF1JLfZvRLAgwBHcQ0V0wxzAq4Hr/7DV4evzpZV2C5XK7zb+eR//kdA7mX3qA+6jOqcucTVOvimXRbSWqLfB1qM38/mXxcqdDWX/dn71HtPhMDS7oBv3puY78uk1sCVIbL8j15Tl7/8ubNC0eRf6P/qhfW3caRvSPna48M529hbixgXTyv85wxnalFbnKnC4gbJXaUIouKHJj5Q80HcEUE12XzH9cI3ZaGkLHEhs6pBafE4ob+3f6K0vbj4N7T6O33HJUQr6KEUmyXwq3i62o8hHZeU2WXBmP3Kf71pWNmf1EkbagYx8pjQX0ulLoG5vZaE/x+dX2qNVzOwX/qEZhaXzbvlVWkCemUAT0kLyqXz/pV2uv+XCY4zZ3AHWoVoxDgAhU7Ad9+N/c3qZ18LzUuvkCNi21qdWQ/1AyTV1VqLB2Q4i59lZdCqaKmtprxQ+pqN7KMOCaO/EtNaI2FQ2Lb1cvnFhe+s43JGZ3X8+8a4aPLPyKHqtUz1KOd4pTBL+z5JvQ9uI2pHK4amFaR3eep3LHnE3Hhp6Mdg1Z7yHpqwvczZ2RY6F76xJGJFS+gPMp0eGcyU4y2OKs/2wDfWnps0GchbsOu7vqLXIvKcpsZR3DOQpZJ4AKVhrN7IXa+RcDRxfnFWQ8+ohW4ZBr5aT1F8bVbv0PO4YLgVxMrck/ONC+PX73uPdNsJtuDtTw9U39zfiZLM4JSfeBhfVUmTvaTiZuv6BlspJGK6vmQ3euSaff1a5i2rt9VZH/X73r/nnvMLr1lKMmVoG1mejO6pTwDmGW6qNx0BdX7GT+XexbIEbmf4NP43IXg/F+US/55w4Xfoc5p8Dw3T+YNvuWNN7eYtlZ/xP2Y7YB3WFw3X+tTKpNx1XYrWwudZ+k8S+dZOs/SeZbOs3SepfMsnWfpPEvnWTrPciDPsrMjKdFbLamOtHtSZUj88p6axP/+BQAA//8=
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Payments
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
        public LinkDescription()
        {
        }

        /// <summary>
        /// The media type in which to submit the request data.
        /// </summary>
        [DataMember(Name = "encType", EmitDefaultValue = false)]
        public string EncType { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The complete target URL. To make the related call, combine the method with this [URI Template-formatted](https://tools.ietf.org/html/rfc6570) link. For pre-processing, include the `$`, `(`, and `)` characters. The `href` is the key HATEOAS component that links a completed call with a subsequent call.
        /// </summary>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public string Href { get; set; } = null!;

        /// <summary>
        /// The media type, as defined by [RFC 2046](https://www.ietf.org/rfc/rfc2046.txt). Describes the link target.
        /// </summary>
        [DataMember(Name = "mediaType", EmitDefaultValue = false)]
        public string MediaType { get; set; } = null!;

        /// <summary>
        /// The HTTP method required to make the related call.
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The [link relation type](https://tools.ietf.org/html/rfc5988#section-4), which serves as an ID for a link that unambiguously describes the semantics of the link. See [Link Relations](https://www.iana.org/assignments/link-relations/link-relations.xhtml).
        /// </summary>
        [DataMember(Name = "rel", EmitDefaultValue = false)]
        public string Rel { get; set; } = null!;

        // /// <summary>
        // /// The request data or link target.
        // /// </summary>
        // [DataMember(Name="schema", EmitDefaultValue = false)]
        // public LinkSchema<T> Schema { get; set; } = null!;
        // /// <summary>
        // /// The request data or link target.
        // /// </summary>
        // [DataMember(Name="targetSchema", EmitDefaultValue = false)]
        // public LinkSchema<T> TargetSchema { get; set; } = null!;
        /// <summary>
        /// The link title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; } = null!;
    }
}
