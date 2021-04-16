// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// Media.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/6ySwUrDQBCG7z7FsKcWYlNEPeSmWKFIbNHipfSwTSbJwmZ2nZ1gg/TdJbVUS0BFPe6/DPPt9++rWrQeVaJSzI1WkXrSbPTa4r2uu1hF6g7bj8MNhoyNF+NIJWpRIdTdIEjrETTlkDkS3MgpUuZyQyWErMIaRypSV8y6fV83jtQD6nxGtlVJoW3ALnhuDGN+CObsPLIYDCpZHkCDsKGyT7o2pLmd7Ncecfeu+q/YYVMfGx4RYZk2Voxv2LuAMCVBJhRItbEw2QhSMI4CDNJpOhnCXLPAjDCBW8e1FnDFpxkMQZcI1y43GFaDSsSHJI7FORtGBqUYOS7jSmobc5Gdjc8vhn91R4212+hbgV2FR9r2wVeV/9rP4sUlsPtz0GH9yMTl/5hYbU/eAAAA//8=
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Payments
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
        public Media()
        {
        }

        /// <summary>
        /// The content-encoding scheme. See [Multipurpose Internet Mail Extensions (MIME) Part One: Format of Internet Message Bodies](https://tools.ietf.org/html/rfc2045).
        /// </summary>
        [DataMember(Name = "binaryEncoding", EmitDefaultValue = false)]
        public string BinaryEncoding { get; set; } = null!;

        /// <summary>
        /// The media type. See [Multipurpose Internet Mail Extensions (MIME) Part Two: Media Types](https://tools.ietf.org/html/rfc2046).
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; } = null!;
    }
}
