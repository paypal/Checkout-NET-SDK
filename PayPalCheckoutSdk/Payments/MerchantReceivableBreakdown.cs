// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// MerchantReceivableBreakdown.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/+xZ348TORJ+v7+i1E8ghQkMDCfN0/FTx52AETu70opFoWJXp61x203ZTuhd8b+vqt2dpJOgnd0dkBbyNOoq2+Xvc9Xniue34rJtqDgvXhKrCl2EN6TILHFuCR4z4ZX2K1dMip+QjRhfYS3Di0nxf2o3H08pKDZNNN4V58VlRaAporGkYT6sAr6EWBEobGJi0tBgW5OLJ8WkeMSMbd7K3UnxhlC/drYtzku0gcTwIRkmvTZcsG+Io6FQnL9dg3j2UTAsCN5gpP1NU++ecXZvEOx69uEMI0BGQKwwCkLi2jgKHSysfXIRogfl3ZI4Qsm+Bu8IVGImp1pxovOxIl7bbg59iGzcYh928IkVzYaAI+D7vn3ob2PFRHdUhYwqEsOLH17feXB6798bXMprendrqr0KU+MiLRhlgak2TCpOmUKcDoPvyOAwvZ1JNJpcNKXpSbwpVlyy9tPkD6mJyAuKh6nZ931X1CzRpnGRDJZ9GjJVG8y5FE7g2Ydklmgpl4VUQnImDjqQc2+DC557rjFG0oABOq6IwTNoUqZGC90GYGVi1a0VPdw7A20WJgb5kDXZLKp1gGFe483fV5mOtndbxL30jtp93hbsQ5hlBkb07Tj2WdzQ5/SgJqVnQCiNQ6cMWoiMLqCSWRMISVVCFcIcLTpFQlYvqqATfXlpGbY8k8Qdod31/ANrJ3L68qXTeSawqoyqoO6yd07nv6S7d++rZLu/lL+syV+P3Lo2JDt6aILUmiuC9/+7+Pl9JgGZwPkIsW2MQmtbKDnnDtqTvOh0WHUnxrp2hhmHY12+eroVK6S5NkujScsOpSB9Cuh0rMLhcNMB4XPPuXx78sGlei7FX26K2KKi0BfEKEMmEIjg7ZPB9kQS4c+mzU1kxjXUwVE8pA0j81EZjspwVIbvTRkabBu0s5LG+TEyH5XhqAxHZfhmleHCYiw91/CcDrxeNL1XtCCMNWLHM86YRw5QNinEDCNz0XN0khBEYQLK17UJwXgXJuKds78ixgV1/v68QvDKoPxA636EXeMx5+Ff14/P6OSB7unYOR318aiP30HnNLxRP8ZABzuo/ebpM31Tfp3O0IWkelh6VXng7gm8T/MyOR06+SiTLY212exZE5/A5fZcEwBt8HDl/MqJiMjAbg9fQTWsIRdnRo8VY8u6T0KT5taoTV3n5MemAcXUyfy8HbEzzWDghYvsdVKkIXoIqWk8R0hBroNAAW7JOnSyOIHHjMZdMhFsJU2+PS6wvUB7G1YVcU8TUI3GzlBrphBEeYfIM6OFXqk8XKKxgvwrPYSO9jT+r8GOZ59hAc0OszyYX0lnhNDP6St4br26+pB8pO1CDpG9W2TLKx8HAZtu2+HHRk7g4QNYS37oZAOt9Ss5QCq9fDoNp2dnnxuFpdwVctI5htRvDvCfPujGAsEs3An8169oSTzpZi3IEXdiiEpRI5lT40dTpxosuUWscmK5MXo50NOz7a3nemowCmuwJB5uGxFDB8l1JOnr7hLoowlxrZO7NH+d9NnK4FHyjO37qZPLo6sLhhdPh+tMNAZqDFekhSBp2Ibn7n4GKtW1Ob3cSwo6uT7kCKRE+9bNsO5aQEM97bvzAjB1Eea2BXKK2+5gu0YKGvYNG4rILSwFsOte3UWY75/K3BSyOJCTQ+kvopDsTb3DX+MXNa//k3noye2Q99g/HvvHY//4jfWP7z7963cAAAD//w==
// DO NOT EDIT

using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Payments
{
    /// <summary>
    /// The detailed breakdown of the captured payment.
    /// </summary>
    [DataContract]
    public class MerchantReceivableBreakdown
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public MerchantReceivableBreakdown()
        {
        }

        /// <summary>
        /// The exchange rate that determines the amount to convert from one currency to another currency.
        /// </summary>
        [DataMember(Name = "exchange_rate", EmitDefaultValue = false)]
        public ExchangeRate ExchangeRate { get; set; } = null!;

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
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "paypal_fee", EmitDefaultValue = false)]
        public Money PaypalFee { get; set; } = null!;

        /// <summary>
        /// An array of platform or partner fees, commissions, or brokerage fees that associated with the captured payment.
        /// </summary>
        [DataMember(Name = "platform_fees", EmitDefaultValue = false)]
        public List<PlatformFee> PlatformFees { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "receivable_amount", EmitDefaultValue = false)]
        public Money ReceivableAmount { get; set; } = null!;
    }
}
