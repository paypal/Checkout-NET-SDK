using PayPal.Sdk.Checkout.Extensions;
using PayPal.Sdk.Checkout.Orders;
using PayPal.Sdk.Checkout.Test.Infrastructure;
using System.Threading.Tasks;
using Xunit;

namespace PayPal.Sdk.Checkout.Test.Orders
{
    [Collection("Orders")]
    public class OrdersCaptureTest
    {
        [Fact(Skip = "This test is an example. In production, you will need a credit card")]
        public async Task TestOrdersCaptureRequest()
        {
            using var payPalHttpClient = TestHttpClientFactory.CreateHttpClient();

            var accessToken = await payPalHttpClient.AuthenticateAsync();

            Assert.NotNull(accessToken);

            var orderResponse = await OrdersCreateTest.CreateOrder(payPalHttpClient, accessToken!);
            var createdOrder = orderResponse.ResponseBody!;

            var request = new OrdersCaptureRequest(createdOrder.Id);
            request.SetRequestBody(new OrderActionRequest
            {
                PaymentSource = new PaymentSource
                {
                    Card = new Card { },
                    Token = new Token { },
                }
            });

            var response = await payPalHttpClient.ExecuteAsync<OrdersCaptureRequest, Order>(request, accessToken);

            Assert.Equal(201, (int) response.ResponseStatusCode);
            Assert.NotNull(response.ResponseBody);
        }
    }
}
