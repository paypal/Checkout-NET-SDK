// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// CaptureRequestApplicationContext.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// Contains request data specific to capture application context.
    /// </summary>
    [DataContract]
    public class CaptureRequestApplicationContext
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CaptureRequestApplicationContext() {}

        /// <summary>
        /// Contains supplementary data specific to capture request context.
        /// </summary>
        [DataMember(Name="supplementary_data", EmitDefaultValue = false)]
        public List<SupplementaryData> SupplementaryData;
    }
}

