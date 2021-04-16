using PayPalCheckoutSdk.Orders;
using Xunit;

namespace PayPalCheckoutSdk.Test.Orders
{
    [Collection("Orders")]
    public class OrdersValidateTest
    {
        [Fact(Skip = "This test is an example. In production, you will need payer approval")]
        public async void TestOrdersValidateRequest()
        {
            var request = new OrdersValidateRequest("ORDER-ID");

            var response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<Order>());
        }
    }
}
