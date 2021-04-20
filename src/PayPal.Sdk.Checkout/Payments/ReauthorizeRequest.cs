// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// ReauthorizeRequest.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/6xUYWvcRhD93l8xiBZakC07aQj1txBTcEsTE7uF4Jp6bnd0GrraVWZnnajF/z2sdLo73V04AvmmHc3OzHvz3v5f3PYdFRfFO8KkTRD+j+AdfUgUtSiLv1AYF47eYJuTirL4nfrN4ZKiEe6Ug5+XiIAe1icL19hfowM0JiSv0GHfktcSFj1cXZ7CbQDyMQmBNqhQJ28joBBEZecAH5FdHqME2RoTpzqAtZIAawT2rIwOtBGiE4s9NMEHgY6EgwX61LFQPIX3IYFB/4V6wbsegjcEtYQWLPYR6pAENMCzX07/Tmdnz81CquGDdo5XNTw/G+80+Eiggj7mthYi55raEFhUglAP30F4yT7TsxoFM6El9CFBm6KCEcrpc0qnWdlHJbS52AYM++Xh0puLR1C82qZmq5tGcjU0GAHB08c5vQMgIRrQH2lwcAMHEY6LCAKpyws4P3/xwxepIwvYZo2V4IPmdPpkKEc9sM9ExoH371++gD9vLo/MeJO6LojGURC54cNY/QFk9Ah0KNiSkpwWZfFKBPvRUGdl9oN9611fXNToIuXAh5R1sA5cS+hIlCkWF3drK/4RPPX75hs7zyy4Ds2NeNsQmCRC3vSAfqJk4BChZo/eDCbJykQzqi0m08Cw1gU6zJTnva5WYBN9O3xRhf1yH+A08j8mWJrh3P2zD/duNLxpUNDkx+Dq5u3Jz8/OX26IyHfvf6xsMLFir7SUwWeVZSGjlVDUako+ycmx+ml8j9iSV66Z4qCBKemrGFFJO4T45NxTeZSVR3RpzsYU2Wdh+FPCx4ZNAy0vG4UFXYyiTm5b4o5XNs+2UFqSDOpYQctIHf9L8PDb9fuHkYT8HA+W6js26FwPtYzaQbeyUTVV3ekBlgy36NY3Dve6fXO51SumheVHtmTzhAG0CSmit9rEw+2qCeGvQYY9yYp88KldkGTbT4N0Dg3FlSFmCikhEsHd6yn2Ogvha2XzLZRx/3T/9N1nAAAA//8=
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Payments
{
    /// <summary>
    /// Reauthorizes an authorized PayPal account payment, by ID. To ensure that funds are still available, reauthorize a payment after its initial three-day honor period expires. You can reauthorize a payment only once from days four to 29.<br/><br/>If 30 days have transpired since the date of the original authorization, you must create an authorized payment instead of reauthorizing the original authorized payment.<br/><br/>A reauthorized payment itself has a new honor period of three days.<br/><br/>You can reauthorize an authorized payment once for up to 115% of the original authorized amount, not to exceed an increase of $75 USD.<br/><br/>Supports only the `amount` request parameter.
    /// </summary>
    [DataContract]
    public class ReauthorizeRequest
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public ReauthorizeRequest()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount { get; set; } = null!;
    }
}
