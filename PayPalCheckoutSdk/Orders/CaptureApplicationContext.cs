// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// CaptureApplicationContext.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The data required to capture application context.
    /// </summary>
    [DataContract]
    public class CaptureApplicationContext
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CaptureApplicationContext() {}

        /// <summary>
        /// An array of supplementary data required to capture context.
        /// </summary>
        [DataMember(Name="supplementary_data", EmitDefaultValue = false)]
        public List<SupplementaryData> SupplementaryData;
    }
}

