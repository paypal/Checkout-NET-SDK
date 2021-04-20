using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.Core;
using PayPal.Sdk.Checkout.Extensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayPal.Sdk.Checkout.Orders;

namespace PayPalCheckoutSdk.Samples
{
    public static class PatchOrderSample
    {
        /**
            This method can be used to build the patch request body.
         */
        private static List<Patch<string>> BuildPatches()
        {
            var patches = new List<Patch<string>>
            {
                new()
                {
                    Op = "replace",
                    Path = "/intent",
                    Value = "CAPTURE"
                },
                new()
                {
                    Op = "replace",
                    Path = "/purchase_units/@reference_id=='PUHF'/description",
                    Value = "Physical Goods"
                }
            };
            return patches;
        }

        /*
            This method cn be used to patch an order by passing the order id.
         */
        public static async Task<Order> PatchOrder(this PayPalHttpClient httpClient, AccessToken accessToken, string orderId, bool debug = false)
        {
            await httpClient.OrdersPatchRequestAsync(
                accessToken,
                orderId,
                BuildPatches()
            );

            var response = await httpClient.GetOrderAsync(
                accessToken,
                orderId
            );

            if (debug && response != null)
            {
                Console.WriteLine("Retrieved Order Status After Patch");
                Console.WriteLine("Status: {0}", response.Status);
                Console.WriteLine("Order Id: {0}", response.Id);
                Console.WriteLine("Intent: {0}", response.CheckoutPaymentIntent);
                Console.WriteLine("Links:");
                foreach (var link in response.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }

                var amount = response.PurchaseUnits[0].AmountWithBreakdown;
                Console.WriteLine("Total Amount: {0} {1}", amount.CurrencyCode, amount.Value);
                Console.WriteLine("Response JSON: \n {0}", response.AsJson());
            }

            return response;
        }

        /*
            This is the driver method which invokes the patchOrder function with Order Id
            to patch an order details.

            To get the new Order id, we are using the createOrder to create new order
            and then we are using the newly created order id.
         */
        // static void Main(string[] args)
        // {
        //     HttpResponse createdResponse = CreateOrderSample.CreateOrder(true).Result;
        //     Console.WriteLine("\nAfter PATCH (Changed Intent and Amount):");
        //     PatchOrder(createdResponse.Result<Order>().Id, true).Wait();
        // }
    }
}
