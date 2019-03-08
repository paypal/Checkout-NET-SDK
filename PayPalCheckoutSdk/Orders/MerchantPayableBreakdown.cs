// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// MerchantPayableBreakdown.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+yaX28bNxLA3+9TDPSUAIqVOHEO8NM5/3C+Qx0jdQsUaaCMyFktYS65Gc5K2Rb97gWXu5JWWrdOYASos0+GZsglZzjz45D075OruqTJ6eQHYpWjE7jEGheW4AUTXmu/dpPp5GdkE4UXWMS2k+nk/1Rvf7yioNiUYrybnE6ucoJF1xl8BpITMGWV00eT6eSMGes06OPp5B2hfutsPTnN0AaKgk+VYdIbwSX7klgMhcnp++10vaP6cGZL9iHMsfCVk94s9xSHM1YVMzlVAzoNqR1kngEhMw6dMmhBGF1AFXtNIVQqBwyAsECLThF4hhLrgpyArujubA3Cxi0Pje2mPFdeU8/afc2hue8lZ6JHKkdGJcRw/uPbR8+On/x764jY98ODmfYqzIwTWjLGD8y0YVIyYwoy6xo/io3D7CFIjgJGkxOTGQrN2neNvsgjwtWeQ1xl7R/Tv/XKCm3V90YnOfRCo5nCOjcqh8Isc4EFnf5aPX78VFW2+UvplzXp15mDxhfETXS0pkVLrbkm+Pi/y18+JicgEzgvIHVpFFpbQ8YpdtAepY/Ouq/ujQGalCnQbnoMj3V18WpnrFAttFkZTTrO0IPkvgrotORheLhZZ+Ebz22OJueDq4oFcUzdbiKlRUWhTYhehEwhEMH7l53sZQyELw2bu4iMDzuxcQMdHMkQG3rikQwjGUYy3FsyXJDAWcrhTYED50LFX9FivtiphYa40WvQD6YzBxjnH322rYqa8Epei/51JC1ZjuAdScWONKxzcr0s6ddSYAJok2XEESsZ+2Kw8SXWl2gBlWqMXufE1ChKrIkg91Y3uWgY4lfDnsOf33mJprxbEQvpIRQPKEcgj0AegXxvgfz6czx2LgneodBhiFCrnnNSb0NlX3MYMl0LiC2S9zUJcWFcG+4tPMRDC57EUe92ICMe0HnJib8uO76KF8FXrGjeDdgz/FD3D2TGgFduCQ1BXpIMu+ZQ91255kt4mly1s5e25cfrT5VZoaWUFjETKmekqyZS7G3tgjeeCxQhHffXDreeNzRqJgBrI3nzLfHw5AS0WRoJ0JCPgBuYtwNsKOaNkztx2y3OhWW68hoqSA5UYzkyliNjOXLPypHbMaJEO8+I9vmwFY9sGNkwsuHeHlUuLUrmuYA3NHBSKVttZEHoM2JPc/MFUdcyJT2LiwFBFKagfFGYEIx3YRq1C/bXxLikRr+5SBp8Zrv7O5yBQmkskEYIjhD8Dp7Wuv8TeIGBBsukwwrphuJIk6CxW3gV3afXuQcmRWbVhnlzM93gI6tsZqxNYs+a+AiudvuaAGiDh2vn1y5CZHPX/Q2oYQ05mRvdJ8aO9NAJZbWwRm3zOgU/liUoJowH60Xd884sGQPnTtjrSpGOB+lQlaVngSoQKAwU4EH8Dh0tj+AFo3FXTAQ7QZPO5Ol14GH7LJCeBKhAY+eoNVMIkbzdyHPTPDrEzMMVGhst/0Y3G7059a8B9zSHHo5Gs8OEB/Mb6WQhtH3aDF5Yr64/VV5oN5GDsHfLJLnw0gFstiuHn8q4As+fwQb5ocEGWuvXcQEp8/Gn03B8cnJTK8ziXhFXOo0R8zcN8J920K0Eglm6I/ivX9OKeNr0WpIjbmCISlEZI6fAz6aoCrDklpKnwHJ96+OCHp/sTj3lU4kSvQYr4m63iTB0ULnGSfq2swT6bIJsOLnv5m8TPjsR3AuevvwwdNrHs5gXDOevuu0sMgYKDNeko4NiVXbDc1uL+xiCLm4fcQliijbJJ7lh3dR5hlq37/cLwNSMsLA1kFNcNwvbFFJQsi/ZkCDXsIoGu+YaLYL56XHsW4UEB3JxUdqNKFT2ri7WbnFsFi9o56ksHX7yu6nFWEeOdeRYR967i7Z//QkAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
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
        public MerchantPayableBreakdown() {}

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="gross_amount", EmitDefaultValue = false)]
        public Money GrossAmount;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="net_amount", EmitDefaultValue = false)]
        public Money NetAmount;

        /// <summary>
        /// An array of breakdown values for the net amount. Returned when the currency of the refund is different from the currency of the PayPal account where the payee holds their funds.
        /// </summary>
        [DataMember(Name="net_amount_breakdown", EmitDefaultValue = false)]
        public List<NetAmountBreakdownItem> NetAmountBreakdown;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="paypal_fee", EmitDefaultValue = false)]
        public Money PaypalFee;

        /// <summary>
        /// An array of platform or partner fees, commissions, or brokerage fees for the refund.
        /// </summary>
        [DataMember(Name="platform_fees", EmitDefaultValue = false)]
        public List<PlatformFee> PlatformFees;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="total_refunded_amount", EmitDefaultValue = false)]
        public Money TotalRefundedAmount;
    }
}

