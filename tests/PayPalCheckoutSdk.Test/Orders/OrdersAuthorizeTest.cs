using PayPal.Sdk.Checkout.Extensions;
using PayPal.Sdk.Checkout.Orders;
using Xunit;

namespace PayPalCheckoutSdk.Test.Orders
{
    [Collection("Orders")]
    public class OrdersAuthorizeTest
    {
        [Theory(Skip = "This test is an example. In production, you will need payer approval")]
        [InlineData("ORDER-ID")]
        public async void TestOrdersAuthorizeRequest(string orderId)
        {
            using var payPalHttpClient = TestHarness.CreateHttpClient();

            var accessToken = await payPalHttpClient.AuthenticateAsync();

            var request = new OrdersAuthorizeRequest(orderId);

            var response = await payPalHttpClient.ExecuteAsync<OrdersAuthorizeRequest, AuthorizeRequest, Order>(request, accessToken);

            Assert.Equal(200, (int) response.ResponseStatusCode);
            Assert.NotNull(response.ResponseBody);
        }
    }
}
