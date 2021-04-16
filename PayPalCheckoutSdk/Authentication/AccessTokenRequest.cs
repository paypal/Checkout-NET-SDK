using PayPalCheckoutSdk.Configuration;
using PayPalCheckoutSdk.Core.MessageSerializers;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PayPalCheckoutSdk.Authentication
{
    public class AccessTokenRequest : BaseHttpRequest<AccessToken, IDictionary<string, string>>
    {
        public AccessTokenRequest(
            PayPalOptions options,
            string? refreshToken = null
        ) : base("/v1/oauth2/token", HttpMethod.Post)
        {
            Authorization = new AuthenticationHeaderValue("Basic", options.AuthorizationString());
            ContentType = FormEncodedSerializer.ApplicationXForm;

            var body = new Dictionary<string, string>
            {
                ["grant_type"] = "client_credentials",
            };

            if (refreshToken != null)
            {
                body["grant_type"] = "refresh_token";
                body["refresh_token"] = refreshToken;
            }

            SetRequestBody(body);
        }
    }
}
