// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Payee.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+xWTW8bRw++v7+C2FMMrCXHiXPQ6U3kADUKuEbq9pIaMjVDaQee5Ww4M5a3hf97MbMrWyvJrdEPt2h7EbDkUCQfPvz4qbhsGyomRYMtUVEW36MYnFs6x3pT/DW1vaQoi1PySkwTjONiUlxWBDWJqpADrCoHQorMLXkIFcEisvaArGER7cJY24mdaJIRDGyNB7TewQ27FQN2D3MAo6Is3otg2wV7VBafCPU3bNtiskDrKQm+RCOkHwQX4hqSYMgXk88Pafoghpe7eSpriMPM6EGum9LdpJs4t0bB2SksnDwGewhOHpI6VEIYSAM2zQjOOIjTUZGG4MDHpnESIHoChZ58CT6qKmX+QdDwpRCB4UBLweQWViZUcIHtBdoSVhVJ7xGuqUZjZ6i1kPfXKYDrdQQzo68TtOwC4C0am7L+vYBytPa+/FVUc1gDRAeB7kU1JSycE0ZrfiQN2QZ6m9EP8ejojZpbp26+RBcof3e/ygdxvOwk5y7QpBOPN+XwXZPAf/cWVIWCKpB4QCFAa92KNMxp4dInazg+OXnqFS4CdUXvfCin+1D+3zt9lIA3Sx7BV25FtyRltloSk6C1LaBS1CSK1Hhn6liDJV6GKpMKeZh9KuTxyWboXQ81GBJqcEtiFia3HoZkHTmDpJ8bJdCd8WGN8ngb5pehzQZ1B+QZynep07VG7gmBs9PUI0ZVea5Ajf6GdALIp1Zyi1yF3gKVcpEDcKznJJmCrEnnEqTuzI0XKiMaGsy5dLBv23kQyh7mtgViJW0ubKISQiOuEUMBpYXblDCHFMYH9PTmONlG380F4lSUHJ+Qjzb8wd2aZ8ZMG99YbBPsT4z9rSePdejlM40Bf3kdGF44qXMzP3/Yw/umIRSfsEhSFX1wda4LqIrUjYuhhCDIHlX6a1/2XZI3TxN8mSHfeAGV8cFJ++cvkrkg6xmnj03IBuJdwJJizck1RM/EocG2Jg5/DR5bzLqoHO9h0zx6w+T9rOn1G7hsq/as2aTpW6xMuZvgQSE7NgrtcF/A54+j1+/e9q8NL6GxyNCR8OpVFULjJ+PxarUamRBHhsNYSI0vDz99nB5m0zHxwQucG2lsSDtTaK3h5Sw1/PDyWD/oFLuo9A+g/wfII+PVdHrwQhBBF0Q9N0x6vbJ6Bk+nHd8ysXuv/Yisow/5FJkTLPNplJYoMrw+AW2WJvSTddtOOfZpMSUX+KjV5IPpvnoEzk+nB9m7j/OEWTLu/+PVt+cHL3X43AXitGhmne/hDbSr3K3vw6M++hcKfI3svrh3dfsG2aBufwMyPtko/wyOBon7Kn31m67zh2m8Vv13nv/rzvOr+6v7//0MAAD//w==
// DO NOT EDIT

using System.Runtime.Serialization;


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
        public Payee()
        {
        }

        /// <summary>
        /// The public ID for the payee- or merchant-created app. Introduced to support use cases, such as BrainTree integration with PayPal, where payee `email_address` or `merchant_id` is not available.
        /// </summary>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; } = null!;

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [DataMember(Name = "email_address", EmitDefaultValue = false)]
        public string Email { get; set; } = null!;

        /// <summary>
        /// The PayPal payer ID, which is a masked version of the PayPal account number intended for use with third parties. The account number is reversibly encrypted and a proprietary variant of Base32 is used to encode the result.
        /// </summary>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; } = null!;

        /// <summary>
        /// The merchant information. The merchant is also known as the payee. Appears to the customer in checkout, transactions, email receipts, and transaction history.
        /// </summary>
        [DataMember(Name = "display_data", EmitDefaultValue = false)]
        public PayeeDisplayable PayeeDisplayable { get; set; } = null!;
    }
}
