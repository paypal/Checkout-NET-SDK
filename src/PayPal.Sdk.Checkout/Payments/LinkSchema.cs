// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// LinkSchema.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/8SVzU7bQBDH732K0V4KUkhQ1XLILVWpFLVpENBeEIeJPY63Xc+a3TFgVbx7tU4gbJwgVBw47n/24zez8/FXndclqaH6rvkPnCU5Fah66hc6jTNDP7AIRtVT36heLb6QT5wuRVtWQ3WeEzi6qsgLpCgI1oEJ1wm6OUlf9dTIOawXLx321ClhOmVTq2GGxlMQrirtKH0QTpwtyYkmr4YXD4x29psSaeNhmurAgmYsVPiItm2L4V8Ix5Uxd70HwpExMM0gPLUB05hpFsMtlRhpxIABCWwGvpod+OZXfB9CoJsAF5UXuEajUxQCnKNmL4DGRPtj145e6hrXT7jG9bprS6Ub1yxTyKrCOtqhi9vyK6VMc5NFcW7F+i7zajtZSZwSJ+FQjBYZdsnmxWmet9kyh/OCWE7JW1M1Tz8m3Gh+ixjqVs/QGzvFiCEY+t1Shb7bZgrtM2a6V7bXU7Oj44qYUKo3zINiKa/w7pX2ZGgsIHVJgJxCYlnoVg6IE5tqnkNTytTdkNiWjjPN6Orj5bMRfMvU9qLB5jY2nBHBxaQyosvKldYTjFnIMQlMUBs4vhViH1oE7E3Gk+N9OEEnMGUawlfrCpTwd6sz5D3OCT7bVJO/3MtFSj8cDMRa4/uaJOtbNx/kUpiBy5IPhx8/7fdfp57DF0ZhWwpPffl/x+f8xg6hyT4IWM+KxFE3kbh8Rs9gK1EoFutddq8p0/bxa5nWxu+90t34Xe3vuMdsy7cSJT8TdHGkH6trmWcBy9LUILn2i/pEEAuSEwQvkBPy7+Hn6dj3wIcrGlNYw42WfHHuGk1F/deZPCVKKIVHJ9c8bVnfYj6WW/B2y3V59+4fAAAA//8=
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Payments
{
    /// <summary>
    /// The request data or link target.
    /// </summary>
    [DataContract]
    public class LinkSchema<T>
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public LinkSchema()
        {
        }

        /// <summary>
        /// </summary>
        [DataMember(Name = "additionalItems", EmitDefaultValue = false)]
        public T AdditionalItems { get; set; } = default!;

        // /// <summary>
        // /// An array of sub-schemas. The data must validate against all sub-schemas.
        // /// </summary>
        // [DataMember(Name="allOf", EmitDefaultValue = false)]
        // public List<AllOfItem> AllOf { get; set; } = null!;
        // /// <summary>
        // /// An array of sub-schemas. The data must validate against one or more sub-schemas.
        // /// </summary>
        // [DataMember(Name="anyOf", EmitDefaultValue = false)]
        // public List<AnyOfItem> AnyOf { get; set; } = null!;
        /// <summary>
        /// </summary>
        [DataMember(Name = "definitions", EmitDefaultValue = false)]
        public T Definitions { get; set; } = default!;

        /// <summary>
        /// </summary>
        [DataMember(Name = "dependencies", EmitDefaultValue = false)]
        public T Dependencies { get; set; } = default!;

        /// <summary>
        /// </summary>
        [DataMember(Name = "fragmentResolution", EmitDefaultValue = false)]
        public string FragmentResolution { get; set; } = null!;

        /// <summary>
        /// An item.
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public T Items { get; set; } = default!;

        // /// <summary>
        // /// An array of links.
        // /// </summary>
        // [DataMember(Name="links", EmitDefaultValue = false)]
        // public List<Link> Links { get; set; } = null!;
        /// <summary>
        /// The media type and context-encoding scheme.
        /// </summary>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        public Media Media { get; set; } = null!;

        /// <summary>
        /// </summary>
        [DataMember(Name = "not", EmitDefaultValue = false)]
        public T Not { get; set; } = default!;

        // /// <summary>
        // /// An array of sub-schemas. The data must validate against one sub-schema.
        // /// </summary>
        // [DataMember(Name="oneOf", EmitDefaultValue = false)]
        // public List<OneOfItem> OneOf { get; set; } = null!;
        /// <summary>
        /// To apply this schema to the instances' URIs, start the URIs with this value.
        /// </summary>
        [DataMember(Name = "pathStart", EmitDefaultValue = false)]
        public string PathStart { get; set; } = null!;

        /// <summary>
        /// </summary>
        [DataMember(Name = "patternProperties", EmitDefaultValue = false)]
        public T PatternProperties { get; set; } = default!;

        /// <summary>
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public T Properties { get; set; } = default!;
    }
}
