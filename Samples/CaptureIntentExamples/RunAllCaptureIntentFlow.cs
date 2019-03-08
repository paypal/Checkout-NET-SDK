using System;

using Samples.CaptureIntentExamples;
using PayPalCheckoutSdk.Orders;
using PayPalCheckoutSdk.Payments;

namespace Samples
{
public class RunAll
{
    //Rename to Main1 => Main
    static void Main1(string []args){
        Console.WriteLine("Running Capture Intent Flow.."); 
        var createOrderResponse = Samples.CaptureIntentExamples.CreateOrderSample.CreateOrder(true).Result;
        var createOrderResult = createOrderResponse.Result<Order>();
                Console.WriteLine("Status: {0}", createOrderResult.Status);
                Console.WriteLine("Order Id: {0}", createOrderResult.Id);
                Console.WriteLine("Intent: {0}", createOrderResult.Intent);
                Console.WriteLine("Links:");
                foreach (PayPalCheckoutSdk.Orders.LinkDescription link in createOrderResult.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }
                AmountWithBreakdown amount = createOrderResult.PurchaseUnits[0].Amount;
                Console.WriteLine("Total Amount: {0} {1}", amount.CurrencyCode, amount.Value);
        
        Console.WriteLine("Copy approve link and paste it in browser. Login with buyer account and follow the instructions.\nOnce approved hit enter...\n");
        Console.Read();

        Console.WriteLine("Capturing the payment...");
        var captureOrderResponse = CaptureOrderSample.CaptureOrder(createOrderResult.Id, true).Result;
        var captureOrderResult = captureOrderResponse.Result<Order>();
        var captureId= "";
                Console.WriteLine("Status: {0}", captureOrderResult.Status);
                Console.WriteLine("Order Id: {0}", captureOrderResult.Id);
                Console.WriteLine("Intent: {0}", captureOrderResult.Intent);
                Console.WriteLine("Links:");
                foreach (PayPalCheckoutSdk.Orders.LinkDescription link in captureOrderResult.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }
                foreach (PurchaseUnit purchaseUnit in captureOrderResult.PurchaseUnits)
                {
                    foreach (PayPalCheckoutSdk.Orders.Capture capture in purchaseUnit.Payments.Captures)
                    {
                        captureId = capture.Id;
                    }
                }
                AmountWithBreakdown captureAmount = captureOrderResult.PurchaseUnits[0].Amount;
                Console.WriteLine("Buyer:");
                Console.WriteLine("\tEmail Address: {0}\n\tName: {1}\n\tPhone Number: {2}{3}", 
                captureOrderResult.Payer.EmailAddress, captureOrderResult.Payer.Name.FullName, 
                captureOrderResult.Payer.Phone.PhoneNumber.CountryCallingCode, captureOrderResult.Payer.Phone.PhoneNumber.NationalNumber);
        
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