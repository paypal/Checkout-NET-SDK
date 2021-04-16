using System;
using System.Threading.Tasks;
using PayPalCheckoutSdk.Extensions;
using PayPalCheckoutSdk.Payments;

namespace PayPalCheckoutSdk.Samples
{
    public class CapturesRefundSample
    {
        /*
            Method for refund the capture. Valid capture Id should be
	         passed an argument to this method.
        */
        public async static Task<HttpResponse> CapturesRefund(string CaptureId, bool debug = false)
        {
            var request = new CapturesRefundRequest(CaptureId);
            request.SetPreferReturn(EPreferReturn.Representation);
            var refundRequest = new RefundRequest
            {
                Amount = new Money
                {
                    Value = "20.00",
                    CurrencyCode = "USD"
                }
            };
            request.RequestBody(refundRequest);
            var response = await PayPalClient.client().Execute(request);

            if (debug)
            {
                var result = response.Result<Refund>();
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Refund Id: {0}", result.Id);
                Console.WriteLine("Links:");
                foreach (LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }

                Console.WriteLine("Response JSON: \n {0}", PayPalClient.ObjectToJSONString(result));
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
