using System;
using System.Threading.Tasks;
using PayPalCheckoutSdk.Extensions;
using PayPalCheckoutSdk.Orders;

namespace PayPalCheckoutSdk.Samples.CaptureIntentExamples
{
    public class CaptureOrderSample
    {
        /*
            Method to capture order after creation. Valid approved order Id should be
	         passed an argument to this method.
        */
        public async static Task<HttpResponse> CaptureOrder(string OrderId, bool debug = false)
        {
            var request = new OrdersCaptureRequest(OrderId);
            request.SetPreferReturn(EPreferReturn.Representation);
            request.RequestBody(new OrderActionRequest());
            var response = await PayPalClient.client().Execute(request);

            if (debug)
            {
                var result = response.Result<Order>();
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Order Id: {0}", result.Id);
                Console.WriteLine("Intent: {0}", result.CheckoutPaymentIntent);
                Console.WriteLine("Links:");
                foreach (LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }

                Console.WriteLine("Capture Ids: ");
                foreach (PurchaseUnit purchaseUnit in result.PurchaseUnits)
                {
                    foreach (var capture in purchaseUnit.Payments.Captures)
                    {
                        Console.WriteLine("\t {0}", capture.Id);
                    }
                }

                AmountWithBreakdown amount = result.PurchaseUnits[0].AmountWithBreakdown;
                Console.WriteLine("Buyer:");
                Console.WriteLine("\tEmail Address: {0}\n\tName: {1} {2}\n",
                    result.Payer.Email,
                    result.Payer.Name.GivenName,
                    result.Payer.Name.Surname);
                Console.WriteLine("Response JSON:\n{0}", PayPalClient.ObjectToJSONString(result));
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
