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
        [Theory(Skip = "This test is an example. In production, you will need payer approval")]
        [InlineData("ORDER-ID")]
        public async Task TestOrdersCaptureRequest(string orderId)
        {
            using var payPalHttpClient = TestHttpClientFactory.CreateHttpClient();

            var accessToken = await payPalHttpClient.AuthenticateAsync();

            var request = new OrdersCaptureRequest(orderId);
            request.SetRequestBody(new OrderActionRequest());

            var response = await payPalHttpClient.ExecuteAsync<OrdersCaptureRequest, Order>(request, accessToken);

            Assert.Equal(201, (int) response.ResponseStatusCode);
            Assert.NotNull(response.ResponseBody);
        }
    }
}
