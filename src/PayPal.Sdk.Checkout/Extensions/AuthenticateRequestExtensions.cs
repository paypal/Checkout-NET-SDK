using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.Core.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Extensions
{
    public static class AuthenticateRequestExtensions
    {
        public static async Task<AccessToken?> AuthenticateAsync(
            this IPayPalHttpClient payPalHttpClient,
            string? refreshToken = null, CancellationToken cancellationToken = default
        )
        {
            var request = new AccessTokenRequest(payPalHttpClient.GetPayPalOptions, refreshToken);

            var response = await payPalHttpClient.ExecuteAsync<AccessTokenRequest, IDictionary<string, string>, AccessToken>(request, null, cancellationToken);

            return response.ResponseBody;
        }
    }
}
