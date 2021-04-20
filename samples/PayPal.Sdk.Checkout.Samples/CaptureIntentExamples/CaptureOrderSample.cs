using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.Core.Interfaces;
using PayPal.Sdk.Checkout.Extensions;
using PayPal.Sdk.Checkout.Orders;
using System;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Samples.CaptureIntentExamples
{
    public static class CaptureOrderSample
    {
        /*
            Method to capture order after creation. Valid approved order Id should be
	         passed an argument to this method.
        */
        public static async Task<Order?> CaptureOrder(this IPayPalHttpClient httpClient, AccessToken accessToken, string orderId, bool debug = false)
        {
            var response = await httpClient.CaptureOrderAsync(accessToken, orderId);

            if (debug && response != null)
            {
                Console.WriteLine("Status: {0}", response.Status);
                Console.WriteLine("Order Id: {0}", response.Id);
                Console.WriteLine("Intent: {0}", response.CheckoutPaymentIntent);
                Console.WriteLine("Links:");
                foreach (var link in response.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }

                Console.WriteLine("Capture Ids: ");
                foreach (var purchaseUnit in response.PurchaseUnits)
                {
                    foreach (var capture in purchaseUnit.Payments.Captures)
                    {
                        Console.WriteLine("\t {0}", capture.Id);
                    }
                }

                var amount = response.PurchaseUnits[0].AmountWithBreakdown;
                Console.WriteLine("Buyer:");
                Console.WriteLine("\tEmail Address: {0}\n\tName: {1} {2}\n",
                    response.Payer.Email,
                    response.Payer.Name.GivenName,
                    response.Payer.Name.Surname
                );
                Console.WriteLine("Amount: {0}", amount);
                Console.WriteLine("Response JSON:\n{0}", response.AsJson());
            }

            return response;
        }

        /*
            Driver Function to invoke capture payment on order.
            Order Id should be replaced with the valid approved order id.
        */
        //static void Main(string[] args)
        //{
        //    string OrderId = "<<REPLACE-WITH-APPROVED-ORDER-ID>>";
        //    CaptureOrder(OrderId, true).Wait();
        //}
    }
}
