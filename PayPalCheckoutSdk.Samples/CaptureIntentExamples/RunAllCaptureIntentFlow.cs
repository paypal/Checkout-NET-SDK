using PayPalCheckoutSdk.Orders;
using System;

namespace PayPalCheckoutSdk.Samples.CaptureIntentExamples
{
    public class RunAll
    {
        //Rename to Main1 => Main
        static void Main1(string[] args)
        {
            Console.WriteLine("Running Capture Intent Flow..");
            var createOrderResponse = Samples.CaptureIntentExamples.CreateOrderSample.CreateOrder(true).Result;
            var createOrderResult = createOrderResponse.Result<Order>();
            Console.WriteLine("Status: {0}", createOrderResult.Status);
            Console.WriteLine("Order Id: {0}", createOrderResult.Id);
            Console.WriteLine("Intent: {0}", createOrderResult.CheckoutPaymentIntent);
            Console.WriteLine("Links:");
            foreach (PayPalCheckoutSdk.Orders.LinkDescription link in createOrderResult.Links)
            {
                Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            }

            AmountWithBreakdown amount = createOrderResult.PurchaseUnits[0].AmountWithBreakdown;
            Console.WriteLine("Total Amount: {0} {1}", amount.CurrencyCode, amount.Value);

            Console.WriteLine("Copy approve link and paste it in browser. Login with buyer account and follow the instructions.\nOnce approved hit enter...\n");
            Console.Read();

            Console.WriteLine("Capturing the payment...");
            var captureOrderResponse = CaptureOrderSample.CaptureOrder(createOrderResult.Id, true).Result;
            var captureOrderResult = captureOrderResponse.Result<Order>();
            var captureId = "";
            Console.WriteLine("Status: {0}", captureOrderResult.Status);
            Console.WriteLine("Order Id: {0}", captureOrderResult.Id);
            Console.WriteLine("Intent: {0}", captureOrderResult.CheckoutPaymentIntent);
            Console.WriteLine("Links:");
            foreach (PayPalCheckoutSdk.Orders.LinkDescription link in captureOrderResult.Links)
            {
                Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            }

            foreach (PurchaseUnit purchaseUnit in captureOrderResult.PurchaseUnits)
            {
                foreach (var capture in purchaseUnit.Payments.Captures)
                {
                    captureId = capture.Id;
                }
            }

            AmountWithBreakdown captureAmount = captureOrderResult.PurchaseUnits[0].AmountWithBreakdown;
            Console.WriteLine("Buyer:");
            Console.WriteLine("\tEmail Address: {0}\n\tName: {1} {2}",
                captureOrderResult.Payer.Email, captureOrderResult.Payer.Name.GivenName, captureOrderResult.Payer.Name.Surname);

            Console.WriteLine("Refunding the Order....");
            var refundOrderResponse = CapturesRefundSample.CapturesRefund(captureId, true).Result;
            var refundOrderResult = refundOrderResponse.Result<PayPalCheckoutSdk.Payments.Refund>();
            Console.WriteLine("Status: {0}", refundOrderResult.Status);
            Console.WriteLine("Refund Id: {0}", refundOrderResult.Id);
            Console.WriteLine("Links:");
            foreach (PayPalCheckoutSdk.Payments.LinkDescription link in refundOrderResult.Links)
            {
                Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            }
        }
    }
}
