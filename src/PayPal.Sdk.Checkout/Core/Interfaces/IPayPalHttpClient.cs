using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core.Interfaces
{
    public interface IPayPalHttpClient
    {
        PayPalOptions GetPayPalOptions { get; }

        Task<PayPalHttpResponse<TResponse>> ExecuteAsync<TRequest, TRequestBody, TResponse>(
            TRequest request,
            AccessToken? accessToken = null,
            CancellationToken cancellationToken = default
        )
            where TRequest : BaseHttpRequest<TRequestBody>
            where TRequestBody : notnull
            where TResponse : notnull;

        Task<PayPalHttpResponse<TResponse>> ExecuteAsync<TRequest, TResponse>(
            TRequest request,
            AccessToken? accessToken,
            CancellationToken cancellationToken
        )
            where TRequest : BaseHttpRequest
            where TResponse : notnull;

        Task<PayPalHttpResponse> ExecuteVoidAsync<TRequest, TRequestBody>(
            TRequest request,
            AccessToken? accessToken = null,
            CancellationToken cancellationToken = default
        )
            where TRequest : BaseVoidHttpRequest<TRequestBody>
            where TRequestBody : notnull;

        Task<PayPalHttpResponse> ExecuteVoidAsync<TRequest>(
            TRequest request,
            AccessToken? accessToken = null,
            CancellationToken cancellationToken = default
        )
            where TRequest : BaseHttpRequest;
    }
}
