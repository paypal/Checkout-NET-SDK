using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.Core;
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
        public static Task<PayPalHttpResponse<Order>> CreateOrderRawAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            Action<OrdersCreateRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var request = new OrdersCreateRequest();

            configureRequest?.Invoke(request);

            return payPalHttpClient.ExecuteAsync<OrdersCreateRequest, OrderRequest, Order>(request, accessToken, cancellationToken);
        }

        public static async Task<Order?> CreateOrderAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            Action<OrdersCreateRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var response = await payPalHttpClient.CreateOrderRawAsync(
                accessToken,
                configureRequest,
                cancellationToken
            );

            return response.ResponseBody;
        }

        /// <summary>
        /// Authorizes payment for an order. To successfully authorize payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response.
        /// </summary>
        public static Task<PayPalHttpResponse<Order>> AuthorizeOrderRawAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            Action<OrdersAuthorizeRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var request = new OrdersAuthorizeRequest(orderId);

            configureRequest?.Invoke(request);

            return payPalHttpClient.ExecuteAsync<OrdersAuthorizeRequest, AuthorizeRequest, Order>(request, accessToken, cancellationToken);
        }

        /// <summary>
        /// Authorizes payment for an order. To successfully authorize payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response.
        /// </summary>
        public static async Task<Order?> AuthorizeOrderAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            Action<OrdersAuthorizeRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var response = await payPalHttpClient.AuthorizeOrderRawAsync(
                accessToken,
                orderId,
                configureRequest,
                cancellationToken
            );

            return response.ResponseBody;
        }

        /// <summary>
        /// Captures payment for an order. To successfully capture payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response.
        /// </summary>
        public static Task<PayPalHttpResponse<Order>> CaptureOrderRawAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            Action<OrdersCaptureRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var request = new OrdersCaptureRequest(orderId);

            configureRequest?.Invoke(request);

            return payPalHttpClient.ExecuteAsync<OrdersCaptureRequest, OrderActionRequest, Order>(request, accessToken, cancellationToken);
        }

        /// <summary>
        /// Captures payment for an order. To successfully capture payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response.
        /// </summary>
        public static async Task<Order?> CaptureOrderAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            Action<OrdersCaptureRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var response = await payPalHttpClient.CaptureOrderRawAsync(
                accessToken,
                orderId,
                configureRequest,
                cancellationToken
            );

            return response.ResponseBody;
        }

        public static Task<PayPalHttpResponse<Order>> GetOrderRawAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            Action<OrdersGetRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var request = new OrdersGetRequest(orderId);

            configureRequest?.Invoke(request);

            return payPalHttpClient.ExecuteAsync<OrdersGetRequest, Order>(request, accessToken, cancellationToken);
        }

        public static async Task<Order?> GetOrderAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            Action<OrdersGetRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var response = await payPalHttpClient.GetOrderRawAsync(
                accessToken,
                orderId,
                configureRequest,
                cancellationToken
            );

            return response.ResponseBody;
        }

        public static async Task<PayPalHttpResponse> OrdersPatchRequestRawAsync<TPatch>(
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

            return await payPalHttpClient.ExecuteVoidAsync(request, accessToken, cancellationToken);
        }

        public static Task OrdersPatchRequestAsync<TPatch>(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            ICollection<Patch<TPatch>> patchObjects,
            Action<OrdersPatchRequest<TPatch>>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            return payPalHttpClient.OrdersPatchRequestRawAsync(accessToken, orderId, patchObjects, configureRequest, cancellationToken);
        }

        public static async Task<PayPalHttpResponse<Order>> ValidateOrderRawAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            Action<OrdersValidateRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var request = new OrdersValidateRequest(orderId);

            configureRequest?.Invoke(request);

            return await payPalHttpClient.ExecuteAsync<OrdersValidateRequest, OrderActionRequest, Order>(request, accessToken, cancellationToken);
        }

        public static async Task<Order?> ValidateOrderAsync(
            this IPayPalHttpClient payPalHttpClient,
            AccessToken accessToken,
            string orderId,
            Action<OrdersValidateRequest>? configureRequest = null,
            CancellationToken cancellationToken = default
        )
        {
            var response = await payPalHttpClient.ValidateOrderRawAsync(accessToken, orderId, configureRequest, cancellationToken);

            return response.ResponseBody;
        }
    }
}
