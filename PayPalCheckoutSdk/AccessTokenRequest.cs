using PayPalCheckoutSdk.Core;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PayPalCheckoutSdk
{
    public class AccessTokenRequest : BaseHttpRequest<AccessToken, IDictionary<string, string>>
    {
        public AccessTokenRequest(
            PayPalEnvironment environment, string? refreshToken = null
        ) : base("/v1/oauth2/token", HttpMethod.Post)
        {
            Authorization = new AuthenticationHeaderValue("Basic", environment.AuthorizationString());
            var body = new Dictionary<string, string>
            {
                {"grant_type", "client_credentials"}
            };

            if (refreshToken != null)
            {
                body["grant_type"] = "refresh_token";
                body.Add("refresh_token", refreshToken);
            }

            Body = body;

            ContentType = "application/x-www-form-urlencoded";
        }
    }
}
