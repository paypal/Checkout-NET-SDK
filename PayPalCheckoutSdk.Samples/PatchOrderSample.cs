using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayPalCheckoutSdk.Orders;

namespace PayPalCheckoutSdk.Samples
{
    public class PatchOrderSample
    {
        /**
            This method can be used to build the patch request body.
         */
        private static List<Patch<Object>> BuildPatchRequest()
        {
            var patches = new List<Patch<Object>>
            {
                new Patch<Object>
                {
                    Op = "replace",
                    Path = "/intent",
                    Value = "CAPTURE"
                },
                new Patch<Object>
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
        public async static Task<HttpResponse> PatchOrder(string orderId, bool debug = false)
        {
            var request = new OrdersPatchRequest<Object>(orderId);
            request.RequestBody(BuildPatchRequest());
            var response = await PayPalClient.client().Execute(request);
            if (debug)
            {
                var ordersGetRequest = new OrdersGetRequest(orderId);
                response = await PayPalClient.client().Execute(ordersGetRequest);
                var result = response.Result<Order>();
                Console.WriteLine("Retrieved Order Status After Patch");
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Order Id: {0}", result.Id);
                Console.WriteLine("Intent: {0}", result.CheckoutPaymentIntent);
                Console.WriteLine("Links:");
                foreach (LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }

                AmountWithBreakdown amount = result.PurchaseUnits[0].AmountWithBreakdown;
                Console.WriteLine("Total Amount: {0} {1}", amount.CurrencyCode, amount.Value);
                Console.WriteLine("Response JSON: \n {0}", PayPalClient.ObjectToJSONString(result));
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
