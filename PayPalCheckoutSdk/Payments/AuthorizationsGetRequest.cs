// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// AuthorizationsGetRequest.cs
// @version 0.1.0-dev+904328-dirty
// @type request
// @data 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
// DO NOT EDIT

using System;
using System.IO;
using System.Net.Http;


namespace PayPalCheckoutSdk.Payments
{
    /// <summary>
    /// Shows details for an authorized payment, by ID.
    /// </summary>
    public class AuthorizationsGetRequest : BaseHttpRequest<Authorization>
    {
        public AuthorizationsGetRequest(string authorizationId) : base("/v2/payments/authorizations/{authorization_id}?", HttpMethod.Get)
        {
            try
            {
                Path = Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(authorizationId)));
            }
            catch (IOException)
            {
            }

            ContentType = ApplicationJson;
        }
    }
}
