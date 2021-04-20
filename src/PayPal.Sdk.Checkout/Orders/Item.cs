// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Item.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+yUXUscPxTG7/+f4pArhdHx3xYKeydKoRVfqLZQrOjZ5OxO2GwyJifaofjdS+ZlO+MoYitLL7wa8uQk+eXMk+enOKtKEhOhmZYiE1/Ra5waOsJlTz2gqhVEJvYpSK9L1s6KiTgrCBQxahNg5jxwQZBWBWAHU4IyellgILUtMrHrPVbNgTuZ+Eyojq2pxGSGJlASrqP2pFbCiXcledYUxOR8hRrYazsfw0pkmjtfDYB74hg8gUJXAVyV9LeUNhpzlz2Jqnoofdqh/linSTXkveo1cdv06QO3wiOtTbOQTKHZPK+17OOfEV5HtKx5aIKe+AhpV7ENhzFwMi7CbeEMgY3LKfn1wIdFHHA34zFyYCcXsCAqtZ1DtJph4/Tgy+bgBb6wJQ6dpWqMzPhjgNyMx8gyek9WVoBWAS5dtFzTIsy0RSs1GmCPNqBMqzIIURaAARCmaNDK2kglVkuyDCrSGvKkRb6UTg1df39mfN1zLjzRlizQo2Ty8PH0eOvdm//f/25EWnuxkSsnQ64t09xj2iBX2pPk3FPgvCveSsUh3wQukEErsqxnmkL9s7ui9Xj0Bk0cdqNTxl2oZzK4LbQsYKnnRXpZk+9xZ+etjKb+UjMyuhntWqh7Qb52R3u1dFOjFwRXn06+XTVNQE9gHafU1hKNqWDmG++g2W42zbtd750BiqReolmtePiss6P93lkhTpW+0SqFr2UHXLgY0CouwsPH5d0NP7SP0rfNbyMF3GwFUhqUFNoHMXBIBoEIzvc6bS8Z4bm2eQlnXDydBSmILpu3PTDIUP/XsmF839doeI2G12h4TjRc3P33CwAA//8=
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The details for the items to be purchased.
    /// </summary>
    [DataContract]
    public class Item
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Item()
        {
        }

        /// <summary>
        /// The item category type.
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; } = null!;

        /// <summary>
        /// The detailed item description.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The item name or title.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The item quantity. Must be a whole number.
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity { get; set; } = null!;

        /// <summary>
        /// The stock keeping unit (SKU) for the item.
        /// </summary>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "tax", EmitDefaultValue = false)]
        public Money Tax { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "unit_amount", EmitDefaultValue = false)]
        public Money UnitAmount { get; set; } = null!;
    }
}
