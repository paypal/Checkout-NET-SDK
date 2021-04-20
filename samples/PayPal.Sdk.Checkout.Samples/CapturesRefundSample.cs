using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.ContractEnums;
using PayPal.Sdk.Checkout.Core.Interfaces;
using PayPal.Sdk.Checkout.Extensions;
using PayPal.Sdk.Checkout.Payments;
using System;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Samples
{
    public static class CapturesRefundSample
    {
        /// <summary>
        /// Method for refund the capture. Valid capture Id should be passed an argument to this method.
        /// </summary>
        public static async Task<Refund?> CapturesRefund(this IPayPalHttpClient httpClient, AccessToken accessToken, string captureId, bool debug = false)
        {
            var response = await httpClient.CapturesRefundAsync(
                accessToken,
                captureId,
                request =>
                {
                    request.SetPreferReturn(EPreferReturn.Representation);
                    request.SetRequestBody(new RefundRequest
                    {
                        Amount = new Money
                        {
                            Value = "20.00",
                            CurrencyCode = "USD"
                        }
                    });
                }
            );

            if (debug && response != null)
            {
                Console.WriteLine("Status: {0}", response.Status);
                Console.WriteLine("Refund Id: {0}", response.Id);
                Console.WriteLine("Links:");
                foreach (var link in response.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }

                Console.WriteLine("Response JSON: \n {0}", response.AsJson());
            }

            return response;
        }

        /*
            Driver Function to perform refund on capture.
            Capture Id should be replaced with the valid capture id.
        */
        // static void Main(string[] args)
        // {
        //     string CaptureId = "<<REPLACE-WITH-VALID-CAPTURE-ID>>";
        //     CapturesRefund(CaptureId, true).Wait();
        // }
    }
}
