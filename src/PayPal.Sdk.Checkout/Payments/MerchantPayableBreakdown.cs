// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// MerchantPayableBreakdown.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/+yZ32/bOBLH3++vGPipBdy4TZsekKdLf+Fyh02DbnaBRbdwx+TIIkKR6nBkV7vY/31BUbItW9lNi6DApnoyzCFFzpczH43I3ydXdUmT08kPxCpHJ3CJNS4swQsmvNZ+7SbTyc/IJjZeYBH7TqaT/1O9/fOKgmJTivFucjq5ygkW3WDwGUhOwJRVTh9NppMzZqzTpI+nk3eE+q2z9eQ0QxsoNnyqDJPeNFyyL4nFUJicvt8u1zuqD1e2ZB/CHAtfOemtcs9wuGJVMZNTNaDTkPpB5hkQMuPQKYMWhNEFVHHUFEKlcsAACAu06BSBZyixLsgJ6IruztcgbNzy0NluyXPlNfW83bccuvteciZ6pHJkVEIM5z++ffTs+Mm/t0LEsR8ezLRXYWac0JIxPmCmDZOSGVOQWdf5UewcZg9BchQwmpyYzFBo9r7r9EWKCFd7grjK2j+mf6vKCm3VV6NrOVShsUxhnRuVQ2GWucCCTn+tHj9+qirb/FL6Z036d+ag0YK4iY7WteipNdcEH/93+cvHJAIygfMCUpdGobU1ZJxiB+1Reuise+reHKBJmQLtZsTwXFcXr3bmCtVCm5XRpOMKPUjuq4BOSx6Gp5t1Hr7x3OZoEh9cVSyIY+p2CyktKgptQvQiZAqBCN6/7NpexkD40rC5i8j4sBMbN9DBkQyxodc8kmEkw0iGe0uGCxI4Szm8KXDgXKj4K1rMFzu10BA3eh36wXTmAOP6o2bbqqgJr6Ra1NeRtGQ5gnckFTvSsM7J9bKkX0uBCaBNlhFHrGTsi8HOl1hfogVUqnF6nRNTYyi6gi/3VjfpaBjig8Oe5s/vvEpT3q2IhfQQjQeMI5NHJo9MvrdMfv05gmhJ8A6FDkOEWvOck3kbKvuWw5DpekDskdTXJMSFcW24t/AQDy14Ekq924GMeEDnJSf+uuz4Kl4EX7GieTdhz/FD2z+QGQOq3BIagrwkGZbm0PZdSfMlPE1S7bxL2wrk9afKrNBSSouYCZUz0hUUKfa2fsEbzwWKkI7v1w63njc0ahYAayN58yzx8OQEtFkaCdCQj4AbmLcTbCjmjZM7ke0Wn4ZlOvUaKkgOTGM5MpYjYzlyz8qR2zGiRDvPiPb5sG0e2TCyYWTDvf1UubQomecC3tDAl0rZWiMLQp8Re5abz4i6ninpWVwMCKIwBeWLwoRgvAvTaF2wvybGJTX2zVnS4E3b3Z/hDBRKY4E0QnCE4Hdwu9adHL/AQINl0mGFdENxpEnQ2C28NofS69wDkyKzasO8OZlu8JFVNjPWpmbPmvgIrnbHmgBog4dr59cuQiR2bNbwDahhDTmZG90nxk7roQhltbBGbfM6BT+WJSgmjB/Wi7qnziw5A+dO2OtKkY4f0qEqS88CVSBQGCjAg/gcOloewQtG466YCHaCJn2TpwuCh+3NQPNkoAKNnaPWTCFE8nYzz01z7xAzD1dobPT8G51s9NbUPwbcsxwqHJ1mhwkP5jfSyUNox7QZvLBeXX+qvNBuIgdh75ap5cJLB7DZbjv8VMYdeP4MNsgPDTbQWr+OG0iZj3+dhuOTk5t6YRbfFXGn0xwxf9ME/2kn3bZAMEt3BP/1a1oRT5tRS3LEDQxRKSpj5BT42RRVAZbcUvIUWK7vfdzQ45Pdpad8KlGiarAi7t42EYYOKteIpG+7SqDPJsiGk/syf5vw2YngXvD02w9Dp70/i3nBcP6qe51FxkCB4Zp0FChWZTfcuLW4jyHo4usjbkFM0Sb5JDesmzrPUCv7/rgATM0MC1sDOcV1s7FNIQUl+5INCXINq+iwa47RIpifHsexVUhwIBc3pX0Rhcre1cHaLT6bxQvaeSpLh6/8buox1pFjHTnWkffuoO1ffwIAAP//
// DO NOT EDIT

using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.Sdk.Checkout.Payments
{
    /// <summary>
    /// The breakdown of the refund.
    /// </summary>
    [DataContract]
    public class MerchantPayableBreakdown
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public MerchantPayableBreakdown()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "gross_amount", EmitDefaultValue = false)]
        public Money GrossAmount { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "net_amount", EmitDefaultValue = false)]
        public Money NetAmount { get; set; } = null!;

        /// <summary>
        /// An array of breakdown values for the net amount. Returned when the currency of the refund is different from the currency of the PayPal account where the merchant holds their funds.
        /// </summary>
        [DataMember(Name = "net_amount_breakdown", EmitDefaultValue = false)]
        public List<NetAmountBreakdownItem> NetAmountBreakdown { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "paypal_fee", EmitDefaultValue = false)]
        public Money PaypalFee { get; set; } = null!;

        /// <summary>
        /// An array of platform or partner fees, commissions, or brokerage fees for the refund.
        /// </summary>
        [DataMember(Name = "platform_fees", EmitDefaultValue = false)]
        public List<PlatformFee> PlatformFees { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "total_refunded_amount", EmitDefaultValue = false)]
        public Money TotalRefundedAmount { get; set; } = null!;
    }
}
