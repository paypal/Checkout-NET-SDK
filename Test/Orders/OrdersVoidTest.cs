using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPalCheckoutSdk.Test;
using static PayPalCheckoutSdk.Test.TestHarness;


namespace PayPalCheckoutSdk.Orders.Test
{
    [Collection("Orders")]
    public class OrdersVoidTest
    {

        [Fact]
        public async void TestOrdersVoidRequest()
        {
            OrdersVoidRequest request = new OrdersVoidRequest("zgEHzh2GVNr d")
                .PayPalClientMetadataId("I46WVfq8gFL0O")
                .PayPalRequestId("hwHq9EfdpWMfPT7eO")
                .Prefer("iYZUJJ17cDD9gh");

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal((int) response.StatusCode, 200);
            Assert.NotNull(response.Result<Order>());

            // Add your own checks here
        }
    }
}
