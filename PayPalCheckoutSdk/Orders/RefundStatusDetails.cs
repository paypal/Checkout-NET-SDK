// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// RefundStatusDetails.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6yPwUoDMRCG7z7FMOdFPO+tsFWKspZavIiQ0cyaQEzWmQQJ0neXNrAqvXr8v2T++eYL93Vm7HHHU4kWHjLlojBwJh8UO3wk8fQSeKT34zfs8JbrTxhYX8XP2aeIPe4dg22jkCbIjkFar556L7HDlQjVtvSqwx2TvY+hYj9RUD6Cj+KF7QK2kmaW7Fmxf1p0NYuPb+d+wqQp/rFc0Llre4JPV3+7OtJTNNv1OGzGGwNJwFyvNnfrwfzTJbGEcHg+XHwDAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The details of the refund status.
    /// </summary>
    [DataContract]
    public class RefundStatusDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public RefundStatusDetails() {}

        /// <summary>
        /// The reason why the refund has the `PENDING` or `FAILED` status.
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue = false)]
        public string Reason;
    }
}

