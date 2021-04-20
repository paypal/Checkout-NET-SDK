using PayPal.Sdk.Checkout.Extensions;
using System;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Samples.AuthorizeIntentExamples
{
    public static class RunAllAuthorizeIntentFlow
    {
        //Rename to Main1 => Main
        private static async Task Main()
        {
            var payPalHttpClient = SampleHttpClientFactory.CreateHttpClient();

            var accessToken = await payPalHttpClient.AuthenticateAsync();

            Console.WriteLine("Running Authorize Intent Flow..");
            var createOrderResponse = await payPalHttpClient.CreateOrder(accessToken!);

            Console.WriteLine("Status: {0}", createOrderResponse!.Status);
            Console.WriteLine("Order Id: {0}", createOrderResponse.Id);
            Console.WriteLine("Intent: {0}", createOrderResponse.CheckoutPaymentIntent);
            Console.WriteLine("Links:");
            foreach (var link in createOrderResponse.Links)
            {
                Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            }

            var amount = createOrderResponse.PurchaseUnits[0].AmountWithBreakdown;
            Console.WriteLine("Total Amount: {0} {1}", amount.CurrencyCode, amount.Value);

            Console.WriteLine("Copy approve link and paste it in browser. Login with buyer account and follow the instructions.\nOnce approved hit enter...\n");
            Console.Read();

            Console.WriteLine("Authorizing the Order....");
            var authorizeOrderResponse = await payPalHttpClient.AuthorizeOrder(accessToken!, createOrderResponse.Id);

            Console.WriteLine("Status: {0}", authorizeOrderResponse!.Status);
            var authorizationId = authorizeOrderResponse.PurchaseUnits[0].Payments.Authorizations[0].Id;
            Console.WriteLine("Order Id: {0}", authorizeOrderResponse.Id);
            Console.WriteLine("Authorization Id: {0}", authorizeOrderResponse.PurchaseUnits[0].Payments.Authorizations[0].Id);
            Console.WriteLine("Intent: {0}", authorizeOrderResponse.CheckoutPaymentIntent);
            Console.WriteLine("Links:");
            foreach (var link in authorizeOrderResponse.Links)
            {
                Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            }

            var authorizedAmount = authorizeOrderResponse.PurchaseUnits[0].AmountWithBreakdown;
            Console.WriteLine("Buyer:");
            Console.WriteLine("\tEmail Address: {0}", authorizeOrderResponse.Payer.Email);
            Console.WriteLine("AuthorizedAmount: {0}", authorizedAmount);

            Console.WriteLine("Capturing the payment...");
            var captureOrderResponse = await payPalHttpClient.CaptureOrder(accessToken!, authorizationId);

            Console.WriteLine("Status: {0}", captureOrderResponse!.Status);
            Console.WriteLine("Capture Id: {0}", captureOrderResponse.Id);
            Console.WriteLine("Links:");
            foreach (var link in captureOrderResponse.Links)
            {
                Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            }

            Console.WriteLine("Refunding the Order....");
            var refundOrderResponse = await payPalHttpClient.CapturesRefund(accessToken!, captureOrderResponse.Id);

            Console.WriteLine("Status: {0}", refundOrderResponse!.Status);
            Console.WriteLine("Refund Id: {0}", refundOrderResponse.Id);
            Console.WriteLine("Links:");
            foreach (var link in refundOrderResponse.Links)
            {
                Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            }
        }
    }
}
