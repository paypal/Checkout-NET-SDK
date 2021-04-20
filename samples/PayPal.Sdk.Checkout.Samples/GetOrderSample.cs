using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.Core;
using PayPal.Sdk.Checkout.Extensions;
using System;
using System.Threading.Tasks;
using PayPal.Sdk.Checkout.Orders;

namespace PayPal.Sdk.Checkout.Samples
{
    public static class GetOrderSample
    {
        /// <summary>
        /// This method cn be used to retrieve an order by passing the order id.
        /// </summary>
        public static async Task<Order> GetOrder(this PayPalHttpClient httpClient, AccessToken accessToken, string orderId, bool debug = false)
        {
            var response = await httpClient.GetOrderAsync(
                accessToken,
                orderId
            );

            if (debug && response != null)
            {
                Console.WriteLine("Retrieved Order Status");
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
            This is the driver method which invokes the getOrder function with Order Id
            to retrieve an order details.

            To get the correct Order id, we are using the createOrder to create new order
            and then we are using the newly created order id.
         */
        // static void Main(string[] args)
        // {
        //     HttpResponse createdResponse = CreateOrderSample.CreateOrder().Result;
        //     GetOrder(createdResponse.Result<Order>().Id).Wait();
        // }
    }
}
