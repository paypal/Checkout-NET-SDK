using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.ContractEnums;
using PayPal.Sdk.Checkout.Core;
using PayPal.Sdk.Checkout.Extensions;
using System;
using System.Threading.Tasks;
using PayPal.Sdk.Checkout.Payments;

namespace PayPalCheckoutSdk.Samples.AuthorizeIntentExamples
{
    public static class CaptureOrderSample
    {
        /// <summary>
        /// This method can be used to capture the payment on the approved authorization.
        /// </summary>
        public static async Task<Capture> CaptureOrder(this PayPalHttpClient httpClient, AccessToken accessToken, string authorizationId, bool debug = false)
        {
            var response = await httpClient.CapturePaymentAsync(
                accessToken,
                authorizationId,
                request =>
                {
                    request.SetPreferReturn(EPreferReturn.Representation);
                    request.SetRequestBody(new CaptureRequest());
                }
            );

            if (debug && response != null)
            {
                Console.WriteLine("Status: {0}", response.Status);
                Console.WriteLine("Order Id: {0}", response.Id);
                Console.WriteLine("Links:");
                foreach (var link in response.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }

                Console.WriteLine("Response JSON: \n {0}", response.AsJson());
            }

            return response;
        }

        // static async Task Main(string[] args)
        // {
        //     string OrderId = "<<REPLACE-WITH-APPROVED-ORDER-ID>>";
        //     await CaptureOrder(OrderId, true);
        // }
    }
}
