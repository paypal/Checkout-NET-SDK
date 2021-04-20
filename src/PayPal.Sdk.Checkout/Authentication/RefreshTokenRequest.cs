using PayPal.Sdk.Checkout.Configuration;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PayPal.Sdk.Checkout.Authentication
{
    public class RefreshTokenRequest : BaseHttpRequest<RefreshToken, IDictionary<string, string>>
    {
        public RefreshTokenRequest(
            PayPalOptions options, string code
        ) : base("/v1/identity/openidconnect/tokenservice", HttpMethod.Post)
        {
            Authorization = new AuthenticationHeaderValue("Basic", options.AuthorizationString());
            ContentType = FormEncodedSerializer.ApplicationXForm;

            var body = new Dictionary<string, string>
            {
                ["grant_type"] = "authorization_code",
                ["code"] = code,
            };

            SetRequestBody(body);
        }
    }
}
