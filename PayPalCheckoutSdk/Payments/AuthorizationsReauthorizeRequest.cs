// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// AuthorizationsReauthorizeRequest.cs
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
    /// Reauthorizes an authorized PayPal account payment, by ID. To ensure that funds are still available, reauthorize a payment after its initial three-day honor period expires. You can reauthorize a payment only once from days four to 29.<br/><br/>If 30 days have transpired since the date of the original authorization, you must create an authorized payment instead of reauthorizing the original authorized payment.<br/><br/>A reauthorized payment itself has a new honor period of three days.<br/><br/>You can reauthorize an authorized payment once for up to 115% of the original authorized amount, not to exceed an increase of $75 USD.<br/><br/>Supports only the `amount` request parameter.
    /// </summary>
    public class AuthorizationsReauthorizeRequest : BaseHttpRequest<Authorization, ReauthorizeRequest>, IConfigurePrefer, IConfigurePayPalRequestId
    {
        public AuthorizationsReauthorizeRequest(string authorizationId) : base("/v2/payments/authorizations/{authorization_id}/reauthorize?", HttpMethod.Post)
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
