// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// AmountBreakdown.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+yYX2vcOBTF3/dTXPS0C06c3S0U5i1NKLSlSWhDoaQhuSPdiUVkyb2SkpiS715kjyf2zJQSyFNHT4mO/t1z5vrHeH6I87YhMROHtYs2wBsmvFXu3opCfEHWODd0gnVaIQrxgdqnwTF5yboJ2lkxE+cVwXzYDG4BoSLA7tD9p1OhYXenFXlQFFAbDz7KCtBDcAEN6ED1clexlAI+rBRf6abR9qaACq0y3X/a+shoJRWAVoHSXqbFvgC9ALTtvijEITO2vdGDQnwiVKfWtGK2QOMpCd+jZlIr4YxdQxw0eTG7WEX00VlqN3MZSpnkMxI3c5KRmaxsu4J7b7BwDAgLbdFKnWwzWo8y7SpWISHM0SSv4BgabGuyAVSkl/PoA/dVr5kcSr6STtHE6frMpt2LUDHRnqyQUQZiePf5dO/Vf/++fgoi7b38u1RO+lLbQDeM6YBSaSYZSiYfymHxXlrsy38gVBhAK7JBLzT5ruOGRc9KJHBcC8RGYx6L36ZyhyZO0xiUzRS6mQLuKy0rqPVNFWBOs2/x4OB/GU33l/qR0f3o0EKXBXHXHUtryanRtwTX78++XvchIBNYFyC0jZZoTAsL7nsHzX5/aDmcunYHKJK6RrPasf2u85Pj0V0+zpVOz7FKFToIlYserQqV335dOTh867j7nHgZPthYz4kTMIZCGoOS/PKBmHRIAZ4ILo4G7Sg1wnPb5iU643LUG7+gwgpLk/YYq5kLmQuZCzvHhUD1VffNZgqGsZzJkMmQybBrZBhebibdMRIzFTIVMhV2lQpXww8bW/Ewns2cyJzInNg1TgR82PJaMVYzFzIXMhf+MC5cPv71EwAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The breakdown of the amount. Breakdown provides details such as total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.
    /// </summary>
    [DataContract]
    public class AmountBreakdown
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AmountBreakdown() {}

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="handling", EmitDefaultValue = false)]
        public Money Handling;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="insurance", EmitDefaultValue = false)]
        public Money Insurance;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="item_total", EmitDefaultValue = false)]
        public Money ItemTotal;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue = false)]
        public Money Shipping;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="shipping_discount", EmitDefaultValue = false)]
        public Money ShippingDiscount;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="tax_total", EmitDefaultValue = false)]
        public Money TaxTotal;
    }
}

