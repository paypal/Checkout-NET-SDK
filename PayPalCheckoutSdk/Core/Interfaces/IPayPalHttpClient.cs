using PayPalCheckoutSdk.Authentication;
using PayPalCheckoutSdk.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace PayPalCheckoutSdk.Core.Interfaces
{
    public interface IPayPalHttpClient
    {
        PayPalOptions GetPayPalOptions { get; }

        Task<PayPalHttpResponse<TResponse>> ExecuteAsync<TRequest, TRequestBody, TResponse>(
            TRequest request,
            AccessToken? accessToken = null,
            CancellationToken cancellationToken = default
        ) where TRequest : BaseHttpRequest<TRequestBody>;

        Task<PayPalHttpResponse<TResponse>> ExecuteAsync<TRequest, TResponse>(
            TRequest request,
            AccessToken? accessToken,
            CancellationToken cancellationToken
        ) where TRequest : BaseHttpRequest;

        Task<PayPalHttpResponse> ExecuteVoidAsync<TRequest, TRequestBody>(
            TRequest request,
            AccessToken? accessToken = null,
            CancellationToken cancellationToken = default
        ) where TRequest : BaseVoidHttpRequest<TRequestBody>;

        Task<PayPalHttpResponse> ExecuteVoidAsync<TRequest>(
            TRequest request,
            AccessToken? accessToken = null,
            CancellationToken cancellationToken = default
        ) where TRequest : BaseHttpRequest;
    }
}
