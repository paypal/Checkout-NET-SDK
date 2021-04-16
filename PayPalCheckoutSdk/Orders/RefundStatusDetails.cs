// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// RefundStatusDetails.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6yPQUsDMRCF7/6KYc6LeN5bYasUZS1SvIg0o5k1gZisMwkSpP9dNGVRFE8e583H43tvuKszY4/CU4l2r5ly0b3lTD4odnhL4ukh8EjPf2GXXI8EdjiwPoqfs08Re9w5hiMIaYLsGFoLtJZT7HAlQrWZnHV4w2SvY6jYTxSUP4KX4oXtEmwlzSzZs2J/t2zQLD4+/SZNmuI3yyX66dpe8OrqV1dH+nma7XocNuOFgSRgzlebq/Vg/mlJLCEc7g8n7wAAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


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
        public RefundStatusDetails()
        {
        }

        /// <summary>
        /// The reason why the refund has the `PENDING` or `FAILED` status.
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; } = null!;
    }
}
