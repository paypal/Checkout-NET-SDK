using PayPal.Sdk.Checkout.Extensions;
using PayPal.Sdk.Checkout.Test.Infrastructure;
using System.Net;
using Xunit;

namespace PayPal.Sdk.Checkout.Test.Orders
{
    [Collection("Orders")]
    public class OrdersValidateTest
    {
        [Theory(Skip = "This test is an example. In production, you will need payer approval")]
        [InlineData("ORDER-ID")]
        public async void TestOrdersValidateRequest(string orderId)
        {
            using var payPalHttpClient = TestHttpClientFactory.CreateHttpClient();

            var accessToken = await payPalHttpClient.AuthenticateAsync();

            Assert.NotNull(accessToken);

            var response = await payPalHttpClient.ValidateOrderRawAsync(
                accessToken!,
                orderId
            );
            Assert.Equal(HttpStatusCode.OK, response.ResponseStatusCode);
            Assert.NotNull(response.ResponseBody);
        }
    }
}
