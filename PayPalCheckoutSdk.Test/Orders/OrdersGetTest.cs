using PayPalCheckoutSdk.Orders;
using Xunit;
using Xunit.Abstractions;

namespace PayPalCheckoutSdk.Test.Orders
{
    [Collection("Orders")]
    public class OrdersGetTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public OrdersGetTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public async void TestOrdersGetRequest()
        {
            var response = await OrdersCreateTest.CreateOrder();
            Order createdOrder = response.Result<Order>();

            var request = new OrdersGetRequest(createdOrder.Id);

            response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Order retrievedOrder = response.Result<Order>();
            Assert.NotNull(retrievedOrder);
            Assert.Equal(retrievedOrder.Id, createdOrder.Id);
            Assert.NotNull(retrievedOrder.PurchaseUnits);
            Assert.Equal(retrievedOrder.PurchaseUnits.Count, createdOrder.PurchaseUnits.Count);

            for (var count = 0; count < retrievedOrder.PurchaseUnits.Count; count++)
            {
                var retrievedOrderPurchaseUnit = retrievedOrder.PurchaseUnits[count];
                var createdOrderPurchaseUnit = createdOrder.PurchaseUnits[count];
                Assert.Equal(retrievedOrderPurchaseUnit.ReferenceId, createdOrderPurchaseUnit.ReferenceId);
                Assert.Equal(retrievedOrderPurchaseUnit.AmountWithBreakdown.CurrencyCode, createdOrderPurchaseUnit.AmountWithBreakdown.CurrencyCode);
                Assert.Equal(retrievedOrderPurchaseUnit.AmountWithBreakdown.Value, createdOrderPurchaseUnit.AmountWithBreakdown.Value);
            }

            Assert.NotNull(retrievedOrder.CreateTime);

            Assert.NotNull(createdOrder.Links);
            var foundApproveUrl = false;
            foreach (var linkDescription in createdOrder.Links)
            {
                if ("approve".Equals(linkDescription.Rel))
                {
                    foundApproveUrl = true;
                    Assert.NotNull(linkDescription.Href);
                    Assert.Equal("GET", linkDescription.Method);
                    _testOutputHelper.WriteLine(linkDescription.Href);
                }
            }

            _testOutputHelper.WriteLine(createdOrder.Id);
            Assert.True(foundApproveUrl);
            Assert.Equal("CREATED", createdOrder.Status);
        }
    }
}
