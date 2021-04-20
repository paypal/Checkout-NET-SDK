using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.Core.Interfaces;
using PayPal.Sdk.Checkout.Orders;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Extensions
{
    public static class OrderRequestExtensions
    {
        public static async Task<Order?> CreateOrderAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            Action<OrdersCreateRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var request = new OrdersCreateRequest();

            configureRequest?.Invoke(request);

            var response = await payPalHttpClient.ExecuteAsync<OrdersCreateRequest, OrderRequest, Order>(request, accessToken, cancellationToken);

            return response.ResponseBody;
        }

        public static async Task<Order?> AuthorizeOrderAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            Action<OrdersAuthorizeRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var request = new OrdersAuthorizeRequest(orderId);

            configureRequest?.Invoke(request);

            var response = await payPalHttpClient.ExecuteAsync<OrdersAuthorizeRequest, AuthorizeRequest, Order>(request, accessToken, cancellationToken);

            return response.ResponseBody;
        }

        public static async Task<Order?> CaptureOrderAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            Action<OrdersCaptureRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var request = new OrdersCaptureRequest(orderId);

            configureRequest?.Invoke(request);

            var response = await payPalHttpClient.ExecuteAsync<OrdersCaptureRequest, OrderActionRequest, Order>(request, accessToken, cancellationToken);

            return response.ResponseBody;
        }

        public static async Task<Order?> GetOrderAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            Action<OrdersGetRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var request = new OrdersGetRequest(orderId);

            configureRequest?.Invoke(request);

            var response = await payPalHttpClient.ExecuteAsync<OrdersGetRequest, Order>(request, accessToken, cancellationToken);

            return response.ResponseBody;
        }

        public static async Task OrdersPatchRequestAsync<TPatch>(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            ICollection<Patch<TPatch>> patchObjects,
            Action<OrdersPatchRequest<TPatch>>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var request = new OrdersPatchRequest<TPatch>(orderId);

            request.SetRequestBody(patchObjects);

            configureRequest?.Invoke(request);

            await payPalHttpClient.ExecuteVoidAsync(request, accessToken, cancellationToken);
        }
    }
}
