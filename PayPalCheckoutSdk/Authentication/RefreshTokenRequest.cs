using PayPalCheckoutSdk.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PayPalCheckoutSdk.Authentication
{
    public class RefreshTokenRequest : BaseHttpRequest<RefreshToken, IDictionary<string, string>>
    {
        public RefreshTokenRequest(
            PayPalOptions options, string code
        ) : base("/v1/identity/openidconnect/tokenservice", HttpMethod.Post)
        {
            Authorization = new AuthenticationHeaderValue("Basic", options.AuthorizationString());
            ContentType = ApplicationXForm;

            var body = new Dictionary<string, string>
            {
                ["grant_type"] = "authorization_code",
                ["code"] = code,
            };

            SetRequestBody(body);
        }
    }
}
