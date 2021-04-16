// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// AuthorizationStatusDetails.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/6SPQUsDQQxG7/6KkPMinvcmVESEtUjxItJGN3UD05kxySCj9L9LmbqgvQheXx7hfZ+4qpmxRyo+JZUPcklxbU5ebD2ykwTDDh9IhZ4DD7T7g33L9Shihwu2F5V8MLHH1cRwFCFtwSeG72c8Qqa64+jQPp5jh5eqVFvjRYf3TONdDBX7LQXjA3grojzOYKkps7qwYf84rzNXia+nO5TJUvxRPKPT7naC96n+7m69IAab5dWwuBmuN/+NjyWE/dP+7AsAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The details of the authorized payment status.
    /// </summary>
    [DataContract]
    public class AuthorizationStatusDetails
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public AuthorizationStatusDetails()
        {
        }

        /// <summary>
        /// The reason why the authorized status is `PENDING`.
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; } = null!;
    }
}
