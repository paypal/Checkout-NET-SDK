// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Item.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+yUX0vkPBTG799PcciVQrW+f+CFuRNlwRX/sLoLiyt6JjkzDZMmNTnRLYvffcm0HVuriLsy7IVXJU9Okl9Onzw/xHldkZiIA6ZSZOILeo1TQ8dYJlVk4pDqh8E+Bel1xdpZMRHnBYEiRm0CzJwHLgg0UxmAHUwJquhlgYHUtsjErvdYN4ftZOIToTqxphaTGZpASbiJ2pNaCafeVeRZUxCTixVmYK/tfAwqkWnufD0A7olj8AQKXQVwXdHvUtpozH32IqrqofRph/pznSbVkPeq18Rt06cP3ArPtDbNQjKFZvO61rKPv0Z4E9Gy5qEJeuIzpF3FNhzFwMm4CHeFMwQ2llPy64EPizjgbsZj5MBOLmBBVGk7h2g1w8bZ4efNwQt8Y0scOUv1GJnx+wC5GY+RZfSerKwBrQIsXbS8pEWYaYtWajTAHm1AmVZlEKIsAAMgTNGglUsjVViXZBlUpDXkSYt8JZ0auv7xzPi6F1x4oi1ZoEfJ5OHg7GTrv3/+/v+hEWnt5UaunAy5tkxzj2mDXGlPknNPgfOueCsVh3wTuEAGrciynmkKy5/dFa3Ho7do4rAbnTLuwnImg7tCywJKPS/Sy5p8izs7/8poll9qRkY3o10Ly16QX7qjvVq6qdELguuPp1+vmyagJ7COU2pricbUMPONd9BsN5vm3a6PzgBFUpdoViuePuv8eL93VohTpW+1SuFr2QEXLga0iovw9HF5d8MP7aP0bfPbSAE3W4FUBiWF9kEMHJJBIIKLvU7bS0Z4rW3ewhmXL2dBCqKr5m0PDDLU/7RsGN/3PRreo+E9Gl4TDZf3f/0EAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
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
        public Item() {}

        /// <summary>
        /// The item category type.
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue = false)]
        public string Category;

        /// <summary>
        /// The detailed item description.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description;

        /// <summary>
        /// REQUIRED
        /// The item name or title.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name;

        /// <summary>
        /// REQUIRED
        /// The item quantity. Must be a whole number.
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue = false)]
        public string Quantity;

        /// <summary>
        /// The stock keeping unit (SKU) for the item.
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue = false)]
        public string Sku;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue = false)]
        public Money Tax;

        /// <summary>
        /// REQUIRED
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="unit_amount", EmitDefaultValue = false)]
        public Money UnitAmount;
    }
}

