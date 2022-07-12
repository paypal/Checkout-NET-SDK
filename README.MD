# Deprecation Notice:
This SDK is deprecated; you can continue to use it, but no new features or support requests will be accepted. A direct [REST API integration](https://developer.paypal.com/docs/api/orders/v2/) is recommended. Review the [docs on authorization](https://developer.paypal.com/api/rest/authentication/) for authenticating requests with the REST API.

## REST API SDK for Dotnet V2

![Home Image](homepage.jpg)

### To consolidate support across various channels, we have currently turned off the feature of GitHub issues. Please visit https://www.paypal.com/support to submit your request or ask questions within our community forum.

__Welcome to PayPal Dotnet SDK__. This repository contains PayPal's Dotnet SDK and samples for [v2/checkout/orders](https://developer.paypal.com/docs/api/orders/v2/) and [v2/payments](https://developer.paypal.com/docs/api/payments/v2/) APIs.

This is a part of the next major PayPal SDK. It includes a simplified interface to only provide simple model objects and blueprints for HTTP calls. This repo currently contains functionality for PayPal Checkout APIs which includes [Orders V2](https://developer.paypal.com/docs/api/orders/v2/) and [Payments V2](https://developer.paypal.com/docs/api/payments/v2/).

Please refer to the [PayPal Checkout Integration Guide](https://developer.paypal.com/docs/checkout/) for more information. Also refer to [Setup your SDK](https://developer.paypal.com/docs/checkout/reference/server-integration/setup-sdk/) for additional information about setting up the SDK's.


## Prerequisites

.NET 4.6.1 or later

An environment which supports TLS 1.2 (see the TLS-update site for more information)

PayPalHttp 1.0.1

## Usage

### Binaries

It is not necessary to fork this repository for using the PayPal SDK. Please take a look at [PayPal Checkout Server SDK](https://developer.paypal.com/docs/checkout/reference/server-integration) for configuring and working with SDK without forking this code.

For contributing to this repository or using the samples you can fork this repository.

### Setting up credentials
Get client ID and client secret by going to https://developer.paypal.com/developer/applications and generating a REST API app. Get <b>Client ID</b> and <b>Secret</b> from there.

```dotnet
using System;
using PayPalCheckoutSdk.Core;
using PayPalCheckoutSdk.Orders;
using PayPalHttp;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CaptureOrderSample
{
    static String clientId = "PAYPAL-CLIENT-ID";
    static String secret = "PAYPAL-CLIENT-SECRET";

    public static HttpClient client()
    {
    // Creating a sandbox environment
    PayPalEnvironment environment = new SandboxEnvironment(clientId, secret);

    // Creating a client for the environment
    PayPalHttpClient client = new PayPalHttpClient(environment);
    return client;
    }
}
```

## Examples
### Creating an Order
This will create an order and print order id for the created order

```dotnet
public async static Task<HttpResponse> createOrder()
 {
         HttpResponse response;
        // Construct a request object and set desired parameters
        // Here, OrdersCreateRequest() creates a POST request to /v2/checkout/orders
        var order = new OrderRequest() {
                CheckoutPaymentIntent = "CAPTURE",
                PurchaseUnits = new List<PurchaseUnitRequest>()
                {
                    new PurchaseUnitRequest()
                    {
                        Amount = new AmountWithBreakdown()
                        {
                            CurrencyCode = "USD",
                            Value = "100.00"
                        }
                    }
                },
                ApplicationContext = new ApplicationContext()
                {
                    ReturnUrl = "https://www.example.com",
                    CancelUrl = "https://www.example.com"
                }
            };


            // Call API with your client and get a response for your call
            var request = new OrdersCreateRequest();
            request.Prefer("return=representation");
            request.RequestBody(order);
            response = await client().Execute(request);
            var statusCode = response.StatusCode;
            Order result = response.Result<Order>();
            Console.WriteLine("Status: {0}", result.Status);
            Console.WriteLine("Order Id: {0}", result.Id);
            Console.WriteLine("Intent: {0}", result.Intent);
            Console.WriteLine("Links:");
            foreach (LinkDescription link in result.Links)
            {
                 Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            }
            return response;
    }
```

### Capturing an Order
Before capturing an order, order should be approved by the buyer using the approve link in create order response
```dotnet
  public async static Task<HttpResponse> captureOrder()
    {
            // Construct a request object and set desired parameters
            // Replace ORDER-ID with the approved order id from create order
            var request = new OrdersCaptureRequest("APPROVED-ORDER-ID");
            request.RequestBody(new OrderActionRequest());
            HttpResponse response = await client().Execute(request);
            var statusCode = response.StatusCode;
            Order result = response.Result<Order>();
            Console.WriteLine("Status: {0}", result.Status);
            Console.WriteLine("Capture Id: {0}", result.Id);
            return response;
    }
```
## Running tests

To run integration tests using your client id and secret, run the `test` gradle command with the `-Pintegration` flag
```sh
$ PAYPAL_CLIENT_ID=YOUR_SANDBOX_CLIENT_ID PAYPAL_CLIENT_SECRET=YOUR_SANDBOX_CLIENT_SECRET dotnet test -v normal
```

You may use the client id and secret above for demonstration purposes.


## Samples

You can start off by trying out [creating and capturing an order](/Samples/CaptureIntentExamples/RunAllCaptureIntentFlow.cs).

To try out different samples for both create and authorize intent head to [this link](/Samples).

Note: Update the `PayPalClient.cs` with your sandbox client credentials or pass your client credentials as environment variable while executing the samples.


## License
Code released under [SDK LICENSE](LICENSE)  
