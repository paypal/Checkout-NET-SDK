// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// RefundRequest.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/8yV32vkNhDH3/tXDH5pC944/QGFfVsSCmlpEtJQKGnYjKVxrFaWnNFoe+bI/37IWm/i3cAlXB7ubTWar0fz0Xe0H4vroadiWVxRE52GK3qIFKQoi7+QDdaWzrFL+0VZ/E7D0+KUgmLTi/Fupw6AoLCXyKShx6EjJyXUA5ydHsGvngGhidYCj9klGKds1ATogLpeBuBcHWqvh0nRI4vBF0X/xOPjn5TymsZfhJ2PTnK0egqDr/8lJWAcSEvzIkVZrJhxyBSOy+KKUF84OxTLBm2gFHiIhknvApfse2IxFIrlzY7fH97RcIgtH2kGbxeaI7xuCVRkJqcGQKch50GTuRmHTiUOwugCqqQqIUTVAibuNVp0isDzRB50pPfrLwgbd3/Y4HTkdeI963N/57DdG2mZaKFaZFRCDGd/Xix+/vGHX55AJO3td5X2KlTGCd0zpg9U2jApqZiCVFPyIiWH6nuQFgWMJiemMRTGW5+S3kREOO4BcdHax/KzVDZo45zGFDmkMO6U8H9rVAuduW8FalpmF0ebLZxX1uTVysHIgnh0x7a11Kk1/xHc/Xb5912GgEzgvIAMvVFo7QANZ++gPdoOyvTVvRqgSZkO7U7xcq3r89NntUKstdkYTTqd0IO0PgZ0Wtrwcrlq6jAN+zSdCT642NXE4JvdQXqLisJ2IGYOKSEQwc3JFDtJRnirbd7DGbev8IZxG28UrY2eGWQWPnTJ6vIM0g0SL3r2GTF9EGKHFrbaiVkzsjQBPGviI1j1PSGH9ADWXtqRc48D8bfh+XMCrQniOb8+KYc6NDbk291pgEmR2VD40rfllaPkvNBa/HosPiO2v3MIjQnD1rjZW+kv5Kvmcfv4zScAAAD//w==
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Payments
{
    /// <summary>
    /// Refunds a captured payment, by ID. For a full refund, include an empty request body. For a partial refund, include an <code>amount</code> object in the request body.
    /// </summary>
    [DataContract]
    public class RefundRequest
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public RefundRequest()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public string InvoiceId { get; set; } = null!;

        /// <summary>
        /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "note_to_payer", EmitDefaultValue = false)]
        public string NoteToPayer { get; set; } = null!;
    }
}
