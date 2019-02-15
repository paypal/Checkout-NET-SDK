// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Patch.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/8xTwYoUQQy9+xWhzk33iCDY4EHwpLA76ODF8ZCtTk+VVHfKVHqlkf13qa7ZGYYWFkaFPdZLJXnvJflldnMk05otqnWmMl9QPN4FusEhw6YyH2k+P95TsuKjeh5Na3aO4MPn2xuIORv47jtZBWXAGMMMEUU9Bphih0opB4QST2Ip1aYy70RwLv03lflE2N2OYTZtjyFRBn5MXqg7AVvhSKKekmm/npgnFT8e1tR74eGC/hFYS9hPm80ri+CE+rd741RjaptGmUOqPWlfsxwap0NopLev32xe7s2SQ4v4LftRSUqVBkski1VHoCgHUujYTgONCoEt5taQ2cBP563LXwe+p+X/PYaJanjUDj3Lgpfqljsq9XPCseMZhOzPUv5v7R2nEB6qJz3meOHw8lz7ex0rlek6UhHVXdA6As9k8KjnsVseYiAto/9fwytnufZpWbULox6RtVNL5HTZNez+sJLy1FJCx5RgZAUp9AGP+/4vBH97ePEbAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The JSON patch object to apply partial updates to resources.
    /// </summary>
    [DataContract]
    public class Patch<T>
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Patch() {}

        /// <summary>
        /// The <a href="https://tools.ietf.org/html/rfc6901">JSON Pointer</a> to the target document location from which to move the value. Required for the <code>move</code> operation.
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue = false)]
        public string From;

        /// <summary>
        /// REQUIRED
        /// The operation.
        /// </summary>
        [DataMember(Name="op", EmitDefaultValue = false)]
        public string Op;

        /// <summary>
        /// The <a href="https://tools.ietf.org/html/rfc6901">JSON Pointer</a> to the target document location at which to complete the operation.
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue = false)]
        public string Path;

        /// <summary>
        /// The value to apply. The <code>remove</code> operation does not require a value.
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue = false)]
        public T Value;
    }
}

