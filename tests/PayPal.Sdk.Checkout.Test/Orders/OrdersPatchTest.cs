using PayPal.Sdk.Checkout.Extensions;
using PayPal.Sdk.Checkout.Orders;
using System.Collections.Generic;
using System.Net;
using Xunit;

namespace PayPal.Sdk.Checkout.Test.Orders
{
    [Collection("Orders")]
    public class OrdersPatchTest
    {
        private ICollection<Patch<string>> BuildRequestBody()
        {
            return new[]
            {
                new Patch<string>
                {
                    Op = "add",
                    Path = "/purchase_units/@reference_id=='test_ref_id1'/description",
                    Value = "added_description"
                }
            };
        }

        [Fact]
        public async void TestOrdersPatchRequest()
        {
            using var payPalHttpClient = TestHarness.CreateHttpClient();

            var accessToken = await payPalHttpClient.AuthenticateAsync();

            Assert.NotNull(accessToken);

            var response = await OrdersCreateTest.CreateOrder(payPalHttpClient, accessToken!);
            var createdOrder = response.ResponseBody!;

            var patchResponse = await payPalHttpClient.OrdersPatchRequestRawAsync(
                accessToken!,
                createdOrder.Id,
                BuildRequestBody()
            );

            Assert.Equal(HttpStatusCode.NoContent, patchResponse.ResponseStatusCode);

            var getOrderResponse = await payPalHttpClient.GetOrderRawAsync(accessToken!, createdOrder!.Id);

            Assert.Equal(HttpStatusCode.OK, getOrderResponse.ResponseStatusCode);

            var getOrder = getOrderResponse.ResponseBody!;

            var firstPurchaseUnit = getOrder.PurchaseUnits[0];
            Assert.Equal("test_ref_id1", firstPurchaseUnit.ReferenceId);
            Assert.Equal("USD", firstPurchaseUnit.AmountWithBreakdown.CurrencyCode);
            Assert.Equal("100.00", firstPurchaseUnit.AmountWithBreakdown.Value);
            Assert.Equal("added_description", firstPurchaseUnit.Description);
        }
    }
}
