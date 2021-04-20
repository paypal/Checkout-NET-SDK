using PayPal.Sdk.Checkout.Extensions;
using PayPal.Sdk.Checkout.Orders;
using PayPal.Sdk.Checkout.Test.Infrastructure;
using Xunit;

namespace PayPal.Sdk.Checkout.Test.Orders
{
    [Collection("Orders")]
    public class OrdersAuthorizeTest
    {
        [Fact(Skip = "This test is an example. In production, you will need a credit card")]
        public async void TestOrdersAuthorizeRequest()
        {
            using var payPalHttpClient = TestHttpClientFactory.CreateHttpClient();

            var accessToken = await payPalHttpClient.AuthenticateAsync();

            Assert.NotNull(accessToken);

            var orderResponse = await OrdersCreateTest.CreateOrder(payPalHttpClient, accessToken!);
            var createdOrder = orderResponse.ResponseBody!;

            var response = await payPalHttpClient.AuthorizeOrderRawAsync(
                accessToken!,
                createdOrder.Id,
                request =>
                {
                    request.SetRequestBody(new AuthorizeRequest
                    {
                        Amount = new Money { },
                        PaymentSource = new PaymentSource
                        {
                        },
                        ReferenceId = "ReferenceId",
                    });
                }
            );

            Assert.Equal(200, (int) response.ResponseStatusCode);
            Assert.NotNull(response.ResponseBody);
        }
    }
}
