using PayPal.Sdk.Checkout.Orders;
using Xunit;

namespace PayPalCheckoutSdk.Test.Orders
{
    [Collection("Orders")]
    public class OrdersCaptureTest
    {
        [Fact(Skip = "This test is an example. In production, you will need payer approval")]
        public async void TestOrdersCaptureRequest()
        {
            var orderResponse = await OrdersCreateTest.CreateOrder();
            var orderId = orderResponse.Result<Order>().Id;
            var request = new OrdersCaptureRequest(orderId);
            request.RequestBody(new OrderActionRequest());

            var response = await TestHarness.client().Execute(request);
            Assert.Equal(201, (int) response.StatusCode);
            Assert.NotNull(response.Result<Order>());
        }
    }
}
