using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.ContractEnums;
using PayPal.Sdk.Checkout.Core;
using PayPal.Sdk.Checkout.Core.Interfaces;
using PayPal.Sdk.Checkout.Extensions;
using PayPal.Sdk.Checkout.Orders;
using System.Net;
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
                PurchaseUnits = new PurchaseUnitRequest[]
                {
                    new()
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
                },
            };
            return order;
        }

        public static async Task<PayPalHttpResponse<Order>> CreateOrder(IPayPalHttpClient payPalHttpClient, AccessToken accessToken)
        {
            var response = await payPalHttpClient.CreateOrderRawAsync(accessToken, request =>
            {
                request.SetPreferReturn(EPreferReturn.Representation);
                request.SetRequestBody(BuildRequestBody());
            });

            return response;
        }

        [Fact]
        public async void TestOrdersCreateRequest()
        {
            using var payPalHttpClient = TestHarness.CreateHttpClient();

            var accessToken = await payPalHttpClient.AuthenticateAsync();

            Assert.NotNull(accessToken);

            var response = await CreateOrder(payPalHttpClient, accessToken!);

            Assert.Equal(HttpStatusCode.Created, response.ResponseStatusCode);
            Assert.NotNull(response.ResponseBody);

            var createdOrder = response.ResponseBody;
            Assert.NotNull(createdOrder);
            Assert.NotNull(createdOrder!.Id);
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
