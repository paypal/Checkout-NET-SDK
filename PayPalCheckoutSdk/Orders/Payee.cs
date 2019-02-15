// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Payee.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+xXX28bNwx/36cg7ikBXLv/0gc/rXUKrBiWBV22ly4waIn2CdFRV0qKcxvy3QdJ58RnO0WAddmw7cXAkaJI/vgjaf1eXXQtVdPqHDuialT9gmJwYekMmySuRtX31N1/nJJXYtpgHFfT6qImaEhUjRxgXTsQUmSuyUOoCZaRtQdkDctol8baInaiScYwsDUe0HoHV+zWDFgOtimkcTWq3opgV+J8Pqo+Euof2XbVdInWUxJ8jkZI3wnOxbUkwZCvpp/uMvRBDK/2U1TWEIe50YNct6X7SbdxYY0Co4mDWRoSWDoBbFtQQhhIw6LLOWwynJRk4AMHcToq0hAc+Ni2TgJET6DQk4ejdA+NV2N4J2j4QojAcKCVYHIPaxNqOMfuHO0xrGuSHiagBo2do9ZC3oOTO89zoxO87ALgNRqbMv+zoHK09nZ0h+yp8a3FLt0MP2xK+oGXTpoc9T7muljMNQYcwL6j+ALdzP39jycTvG1bQvEJ/CRV0QfXkIBhUDWpKxfDCIIge1Tpaj8qyBZmt8GPMqG3TkBtfHDS/fVEXQiynnP62IZsIN4HLCnALQdsfCQOLXYNcfh78Njh2IOgRG+YvJ/nsIbA7Kr2wUmtJZxJhNb8RrrPru+j8a/x+fNXamGduvocXaD8XX6VD+J4VSRnLtC0iCfbcvi5TRC/eQ2qRkEVSDygEKC1bp3GBC1d+mQNL09OHjqFy0CSC1V8KKf7UL7tnd5LwJsVj+E7t6ZrklG2WhGToLUdoFLUpvnU4I1pYgOWeBXqMr54mH1qpJcn26GXRmsxJNTgmiTNvtRfGJJ15AySfmyUQDfGhw3Kk12Yvy6BzmvH9AX+tL3+AH82qgN7IGmAY7NIUBsGEzwoZMdGoR3SCz69H79487o/bXgFrUWGMsUuj+oQWj+dTNbr9diEODYcJkJqcvHs4/vZs2w6IT5+gn3oIgfp5gqtNbyap6INV+PmQFHso9IfgP4GSAfhaDY7fiKIoATRLAyT3jC8H4GzWRlYeTL2Xos7aKIPeU8uCFZ5jaeeQ4YXJ6DNyoSe/7t2yrFPPE4u8F6ryQdTvnoEzk5nx9m7j4uEWTLu7zj66ez4iSYm3QRibxzPi+9BbQ8o9+t7d6iP/okC3yB7KO593aFNOKjbP4CMDzbKv4OjQeKhSl/eXj6Gptt/aIcc3dH8v9b/w2v9IfpsPX8G5BnK96lT3lb5uSDw4XQE69qoOr8poEF/RToBlIdf38S9BarczZtmSRRkTTqXIL3v8sst1EY0tJhzKbDv2nkQyh4WtgNiJV0ubKISQiuuFUMBpYPrlDCHFMY79PTqZbKNvrwsiXM7p/iEfLThq8zoy9tv/gAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
    /// </summary>
    [DataContract]
    public class Payee
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Payee() {}

        /// <summary>
        /// The public identifier for app created by the merchant/payee. Introduced to support use cases (for e.g. BrainTree integration with PayPal) where payee email_address or merchant_id is not available.
        /// </summary>
        [DataMember(Name="client_id", EmitDefaultValue = false)]
        public string ClientId;

        /// <summary>
        /// The merchant information. The merchant is also known as the payee. Appears to the customer in checkout, transactions, email receipts, and transaction history.
        /// </summary>
        [DataMember(Name="display_data", EmitDefaultValue = false)]
        public DisplayableMerchantInformation DisplayData;

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [DataMember(Name="email_address", EmitDefaultValue = false)]
        public string EmailAddress;

        /// <summary>
        /// The PayPal payer ID, which is a masked version of the PayPal account number intended for use with third parties. The account number is reversibly encrypted and a proprietary variant of Base32 is used to encode the result.
        /// </summary>
        [DataMember(Name="merchant_id", EmitDefaultValue = false)]
        public string MerchantId;
    }
}

