// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// CreditFinancingOffer.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+yVW2vsRgyA3/srhJ9a8MbpBQr7FhICaWkS2lAoadhoZ+T1kPGMq5ETTMl/P4xvm11vzkk4e17CPhlLmpE+jS7/JzdNRck8OWXSRuDcOHTKuBVc5TlxkiZ/IxtcWrrEMtolafI7NeufMwqKTSXGu2Se3BQEmgSNDYBLXwtIQVBhQzwLZEkJaVCdq3x05aOroyRNTpix6QI6TpM/CfWVs00yz9EGioL/asOkR8E1+4pYDIVkfjuiXLggaG1JTuCsC2bKYdZGCz0ardF266e0HRtWFftH0vDiWFR1X4tuyMr+KP/wjpopV+90oWva4NmUTzlUzUxONYBOA5a+dgK5Z8DhndCCMLqAKp5KIdSqAAyAsESLThF4HpF1TfsjDcLGraaoQ8gL5fUm7LZminsrBRPNVIGMSojh4q+r2S8//fjrOhHx7N33mfYqZMYJrRjjBZk2TEoypiDZYDyLxiH7AaRAAaPJickNhbb8B6N3ZUS43kqIq619Tr+YlUe0W08/SKZZaDUpPBVGFVCaVSGwpPm/9fHxz6q27Ze6P2u6vxMHbS6I2+ro0SKpNQ8E979d/3PfJQGZwHkBaSqj0NoGcu5qB+1Rd2k23LrlAzQpU6IdT+z2dXN59sJXqJfaPBrdNqF4kMLXAZ2WIux2lw2E557bd+I++eDqckkMPh8DqSwqCn1DbFRICoEIbk8H2WkshPeWzT4q4+4NtVERG68358IgmlZHHhPSQj0ZKfoqGec5FLH5V0ykQTyU+ECDMo6Ar23/NzOZEOp2Ub2Y3YNoytSp4tO2nflNNtFWo/b9Mo1ciMuNuHvBa0tmXKDreOOJFIyD0rtY6PuN/JUVI17QLiJWLOZNgm3VYdEcFs1h0XzYRfPZCdH36I4BsdYc5sNhPhzmwwebD3fP330CAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The details about the payer-selected credit financing offer.
    /// </summary>
    [DataContract]
    public class CreditFinancingOffer
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditFinancingOffer() {}

        /// <summary>
        /// The payer-approved installment payment plan details.
        /// </summary>
        [DataMember(Name="installment_details", EmitDefaultValue = false)]
        public InstallmentDetails InstallmentDetails;

        /// <summary>
        /// The issuer of the credit financing offer.
        /// </summary>
        [DataMember(Name="issuer", EmitDefaultValue = false)]
        public string Issuer;

        /// <summary>
        /// The payer-selected financing term, in months.
        /// </summary>
        [DataMember(Name="term", EmitDefaultValue = false)]
        public int? Term;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="total_interest", EmitDefaultValue = false)]
        public Money TotalInterest;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="total_payment", EmitDefaultValue = false)]
        public Money TotalPayment;
    }
}

