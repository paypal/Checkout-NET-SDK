// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// StatusDetails.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/6SPQUvDQBCF7/6KYc5BPOcmbJAixKLFiwgZm6lZ2O6uM7PIIv3vUgMRCXjpcb7H8L73hbuaGVt8MrKi4NjIB8UGn0k8vQXu6XjOscF7rr+HY92Lz+ZTxBZ3E8M4v0I6gE0Me8pWhEfIVI8cDfSn4RobvBWhOvfeNPjIND7EULE9UFA+g4/ihccFbCVlFvOs2L4sxmri4/vaVJg0xT++C1pbzxF8TvU/a/AKw7br3aa/GyAJDK7rN50bLp0TSwin19PVNwAAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Payments
{
    /// <summary>
    /// The details of the captured payment status.
    /// </summary>
    [DataContract]
    public class StatusDetails
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public StatusDetails()
        {
        }

        /// <summary>
        /// The reason why the captured payment status is `PENDING` or `DENIED`.
        /// </summary>
        [field: DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; } = null!;
    }
}
