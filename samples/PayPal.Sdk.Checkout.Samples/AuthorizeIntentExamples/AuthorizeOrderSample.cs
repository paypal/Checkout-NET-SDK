using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.ContractEnums;
using PayPal.Sdk.Checkout.Core.Interfaces;
using PayPal.Sdk.Checkout.Extensions;
using PayPal.Sdk.Checkout.Orders;
using System;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Samples.AuthorizeIntentExamples
{
    public static class AuthorizeOrderSample
    {
        /// <summary>
        /// This function can be used to perform authorization on the approved order.
        /// </summary>
        public static async Task<Order?> AuthorizeOrder(this IPayPalHttpClient httpClient, AccessToken accessToken, string orderId, bool debug = false)
        {
            var response = await httpClient.AuthorizeOrderAsync(
                accessToken,
                orderId,
                request =>
                {
                    request.SetPreferReturn(EPreferReturn.Representation);
                    request.SetRequestBody(new AuthorizeRequest());
                }
            );

            if (debug && response != null)
            {
                Console.WriteLine("Status: {0}", response.Status);
                Console.WriteLine("Order Id: {0}", response.Id);
                Console.WriteLine("Authorization Id: {0}", response.PurchaseUnits[0].Payments.Authorizations[0].Id);
                Console.WriteLine("Intent: {0}", response.CheckoutPaymentIntent);
                Console.WriteLine("Links:");
                foreach (var link in response.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }

                var amount = response.PurchaseUnits[0].AmountWithBreakdown;
                Console.WriteLine("Buyer:");
                Console.WriteLine("\tEmail Address: {0}", response.Payer.Email);
                Console.WriteLine("Response JSON: \n {0}", response.AsJson());
            }

            return response;
        }

        //static void Main(string[] args)
        //{
        //    string OrderId = "<<REPLACE-WITH-APPROVED-ORDER-ID>>";
        //    AuthorizeOrder(OrderId, true).Wait();
        //}
    }
}
