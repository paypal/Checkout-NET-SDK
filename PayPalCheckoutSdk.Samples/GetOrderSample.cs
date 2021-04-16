using System;
using System.Threading.Tasks;
using PayPalCheckoutSdk.Orders;

namespace PayPalCheckoutSdk.Samples
{
    public class GetOrderSample
    {
        /*
            This method cn be used to retrieve an order by passing the order id.
         */
        public async static Task<HttpResponse> GetOrder(string orderId, bool debug = false)
        {
            var request = new OrdersGetRequest(orderId);

            var response = await PayPalClient.client().Execute(request);
            var result = response.Result<Order>();
            Console.WriteLine("Retrieved Order Status");
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
