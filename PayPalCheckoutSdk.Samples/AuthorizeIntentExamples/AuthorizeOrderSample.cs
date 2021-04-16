using System;
using System.Threading.Tasks;
using PayPalCheckoutSdk.Orders;

namespace PayPalCheckoutSdk.Samples.AuthorizeIntentExamples
{
    public class AuthorizeOrderSample
    {
        //This function can be used to perform authorization on the approved order.
        public async static Task<HttpResponse> AuthorizeOrder(string OrderId, bool debug = false)
        {
            var request = new OrdersAuthorizeRequest(OrderId);
            request.Prefer("return=representation");
            request.RequestBody(new AuthorizeRequest());
            var response = await PayPalClient.client().Execute(request);

            if (debug)
            {
                var result = response.Result<Order>();
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Order Id: {0}", result.Id);
                Console.WriteLine("Authorization Id: {0}", result.PurchaseUnits[0].Payments.Authorizations[0].Id);
                Console.WriteLine("Intent: {0}", result.CheckoutPaymentIntent);
                Console.WriteLine("Links:");
                foreach (LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }

                AmountWithBreakdown amount = result.PurchaseUnits[0].AmountWithBreakdown;
                Console.WriteLine("Buyer:");
                Console.WriteLine("\tEmail Address: {0}", result.Payer.Email);
                Console.WriteLine("Response JSON: \n {0}", PayPalClient.ObjectToJSONString(result));
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
