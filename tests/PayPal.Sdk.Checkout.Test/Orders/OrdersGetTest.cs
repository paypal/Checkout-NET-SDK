using PayPal.Sdk.Checkout.Extensions;
using PayPal.Sdk.Checkout.Orders;
using System.Net;
using Xunit;
using Xunit.Abstractions;

namespace PayPal.Sdk.Checkout.Test.Orders
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
            using var payPalHttpClient = TestHarness.CreateHttpClient();

            var accessToken = await payPalHttpClient.AuthenticateAsync();

            Assert.NotNull(accessToken);

            var orderResponse = await OrdersCreateTest.CreateOrder(payPalHttpClient, accessToken!);
            var createdOrder = orderResponse.ResponseBody;

            var getOrderResponse = await payPalHttpClient.GetOrderRawAsync(accessToken!, createdOrder!.Id);

            Assert.Equal(HttpStatusCode.OK, getOrderResponse.ResponseStatusCode);

            var retrievedOrder = getOrderResponse.ResponseBody!;
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
                if (linkDescription.Rel == "approve")
                {
                    foundApproveUrl = true;
                    Assert.NotNull(linkDescription.Href);
                    Assert.Equal("GET", linkDescription.Method);
                    _testOutputHelper.WriteLine(linkDescription.Href);
                }
            }

            _testOutputHelper.WriteLine(createdOrder.Id);
            Assert.True(foundApproveUrl);
            Assert.Equal(EOrderStatus.Created, createdOrder.Status);
        }
    }
}
