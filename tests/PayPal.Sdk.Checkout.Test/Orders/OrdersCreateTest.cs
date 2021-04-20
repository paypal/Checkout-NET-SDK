using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.ContractEnums;
using PayPal.Sdk.Checkout.Core;
using PayPal.Sdk.Checkout.Core.Interfaces;
using PayPal.Sdk.Checkout.Extensions;
using PayPal.Sdk.Checkout.Orders;
using PayPal.Sdk.Checkout.Test.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace PayPal.Sdk.Checkout.Test.Orders
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
                CheckoutPaymentIntent = EOrderIntent.Capture,
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
            using var payPalHttpClient = TestHttpClientFactory.CreateHttpClient();

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

            Assert.Contains(createdOrder.Links, x => x.Rel == "approve");
            var approveUrl = createdOrder.Links.First(x => x.Rel == "approve");
            Assert.NotNull(approveUrl.Href);
            Assert.Equal("GET", approveUrl.Method);

            _testOutputHelper.WriteLine("OrderId: {0}", createdOrder.Id);
            _testOutputHelper.WriteLine("ApproveUrl: {0}", approveUrl.Href);

            Assert.Equal(EOrderStatus.Created, createdOrder.Status);
        }
    }
}
