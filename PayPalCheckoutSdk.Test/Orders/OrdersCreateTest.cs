using PayPalCheckoutSdk.Orders;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace PayPalCheckoutSdk.Test.Orders
{
    [Collection("Orders")]
    public class OrdersCreateTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public OrdersCreateTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        private static OrderRequest BuildRequestBody()
        {
            var order = new OrderRequest
            {
                CheckoutPaymentIntent = "CAPTURE",
                PurchaseUnits = new List<PurchaseUnitRequest>
                {
                    new PurchaseUnitRequest
                    {
                        ReferenceId = "test_ref_id1",
                        AmountWithBreakdown = new AmountWithBreakdown
                        {
                            CurrencyCode = "USD",
                            Value = "100.00"
                        }
                    }
                },
                ApplicationContext = new ApplicationContext
                {
                    ReturnUrl = "https://www.example.com",
                    CancelUrl = "https://www.example.com"
                }
            };
            return order;
        }

        public async static Task<HttpResponse> CreateOrder()
        {
            var request = new OrdersCreateRequest();
            request.Prefer("return=representation");
            request.RequestBody(BuildRequestBody());
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestOrdersCreateRequest()
        {
            var response = await CreateOrder();

            Assert.Equal(201, (int) response.StatusCode);
            Assert.NotNull(response.Result<Order>());

            Order createdOrder = response.Result<Order>();
            Assert.NotNull(createdOrder.Id);
            Assert.NotNull(createdOrder.PurchaseUnits);
            Assert.Single(createdOrder.PurchaseUnits);

            var firstPurchaseUnit = createdOrder.PurchaseUnits[0];
            Assert.Equal("test_ref_id1", firstPurchaseUnit.ReferenceId);
            Assert.Equal("USD", firstPurchaseUnit.AmountWithBreakdown.CurrencyCode);
            Assert.Equal("100.00", firstPurchaseUnit.AmountWithBreakdown.Value);

            Assert.NotNull(createdOrder.CreateTime);

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
