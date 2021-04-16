using PayPalCheckoutSdk.Core;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PayPalCheckoutSdk
{
    public class RefreshTokenRequest : BaseHttpRequest<RefreshToken, IDictionary<string, string>>
    {
        public RefreshTokenRequest(
            PayPalEnvironment environment, string code
        ) : base("/v1/identity/openidconnect/tokenservice", HttpMethod.Post)
        {
            Authorization = new AuthenticationHeaderValue("Basic", environment.AuthorizationString());
            Body = new Dictionary<string, string>
            {
                {"grant_type", "authorization_code"},
                {"code", code},
            };
            ContentType = "application/x-www-form-urlencoded";
        }
    }
}
