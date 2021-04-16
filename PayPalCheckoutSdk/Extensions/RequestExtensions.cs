using PayPalCheckoutSdk.Authentication;
using PayPalCheckoutSdk.Core.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace PayPalCheckoutSdk.Extensions
{
    public static class RequestExtensions
    {
        public static async Task<AccessToken?> AuthenticateAsync(
            this IPayPalHttpClient payPalHttpClient,
            string? refreshToken = null, CancellationToken cancellationToken = default)
        {
            var request = new AccessTokenRequest(payPalHttpClient.GetPayPalOptions, refreshToken);

            var response = await payPalHttpClient.ExecuteAsync<AccessTokenRequest, AccessToken, AccessToken>(request, null, cancellationToken);

            return response.ResponseBody;
        }
    }
}
