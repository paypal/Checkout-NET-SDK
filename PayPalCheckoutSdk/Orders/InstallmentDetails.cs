// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// InstallmentDetails.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6xU30scMRB+718x5KmFPdf+gMK9iVKwpSqtFIoVnUtmbwezyXYyUZbS/73s7u3p3Qmt1KeQSTLzfV++mV/mvGvJzM1xSIreNxQUjkiRfTKF+YbCuPB0gk1/yRTmE3X3myNKVrhVjsHMzXlN0GJHMsO2lXhLDvhB1ha7cfUYwI0l9kxhDkSwG1HsF+YLoTsNvjPzCn2iPvAzs5BbB84ktiTKlMz8Yo3/cwzU7SJeFb1ymTbAb8Z3edgsQsF2gMEBNjEHhSoKIFQcMFhGDyoYEtr+VQEp2xowAcICPQZLEGVN2WV6PqZJhcNyl+oE+cpGt0l2+2SX7oXWQjSzNQpaJYHjr6ezd29ev78Xon97+bJ00aaSg9JSsE9QOhayWgolLafLs/5yKl+B1qjAjoJyxZRAH0j7JEVU8pYgIXv/u/irKrfot75+iuyqMJwUcFezraHhZa2woPmPvL//1mY/rDTuPI+7gwCDFiSDO1bUeqaebwiuP559vx5FQCEIUUG7li1630Elo3fQ741JyynrVg1wZLlBv37xeK3zk6MHtVJeOL5lNzShRtA65oTBaZ0eL1dODD9EGf5JVuJDyM2CBGK1BtJ6tJRWDbHhkAISEVwcTrHD3ghPtc1zOOPyH7zRknB0m3NhCu26o+oFGUjdsdYrl+g086Dum38pRA40QoM3NB32I+B/23/F6cUfAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The payer-approved installment payment plan details.
    /// </summary>
    [DataContract]
    public class InstallmentDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public InstallmentDetails() {}

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="payment_due", EmitDefaultValue = false)]
        public Money PaymentDue;

        /// <summary>
        /// The frequency with which the payer has agreed to make the payment.
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue = false)]
        public string Period;
    }
}

