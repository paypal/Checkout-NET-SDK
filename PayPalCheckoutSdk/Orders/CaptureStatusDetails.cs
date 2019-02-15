// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// CaptureStatusDetails.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6SPz0rEQAyH7z5FyLmI597EKbIIddHFiwiN26wdmJ0ZkxQZZN9d1oGKFLx4zJc/vy+fuCuZscUbyjYLw6ORzQqOjXxQbPCJxNNr4J6O5zls8I7LT+FY9+Kz+RSxxd3EMNZVSAewiWFfD4+QqRw5Guh3wiU2eC1CpeZfNfjANN7HULA9UFA+g/fZC48L2ErKLOZZsX1ezNXEx7e1qTBpir98F7S2ri34mMpf1uAVhm3Xu01/O0ASGFzXbzo3/PedOIdwejldfAEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The details of the captured payment status.
    /// </summary>
    [DataContract]
    public class CaptureStatusDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CaptureStatusDetails() {}

        /// <summary>
        /// The reason why the captured payment status is `PENDING` or `DENIED`.
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue = false)]
        public string Reason;
    }
}

