using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Samples;
using PayPalCheckoutSdk.Orders;
using BraintreeHttp;

using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;

namespace Samples.AuthorizeIntentExamples
{
    public class CreateOrderSample
    {
        //Below function can be used to build the create order request body with complete payload.
        private static OrderRequest BuildRequestBody()
        {
            OrderRequest orderRequest = new OrderRequest()
            {
                Intent = "AUTHORIZE",

                ApplicationContext = new ApplicationContext
                {
                    BrandName = "EXAMPLE INC",
                    LandingPage = "BILLING",
                    CancelUrl = "https://www.example.com",
                    ReturnUrl = "https://www.example.com",
                    UserAction = "CONTINUE",
                    ShippingPreference = "SET_PROVIDED_ADDRESS"
                },
                PurchaseUnits = new List<PurchaseUnitRequest>
                {
                    new PurchaseUnitRequest{
                        ReferenceId =  "PUHF",
                        Description = "Sporting Goods",
                        CustomId = "CUST-HighFashions",
                        SoftDescriptor = "HighFashions",
                        Amount = new AmountWithBreakdown
                        {
                            CurrencyCode = "USD",
                            Value = "220.00",
                            Breakdown = new AmountBreakdown
                            {
                                ItemTotal = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = "180.00"
                                },
                                Shipping = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = "20.00"
                                },
                                Handling = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = "10.00"
                                },
                                TaxTotal = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = "20.00"
                                },
                                ShippingDiscount = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = "10.00"
                                }
                            }
                        },
                        Items = new List<Item>
                        {
                            new Item
                            {
                                Name = "T-shirt",
                                Description = "Green XL",
                                Sku = "sku01",
                                UnitAmount = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = "90.00"
                                },
                                Tax = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = "10.00"
                                },
                                Quantity = "1",
                                Category = "PHYSICAL_GOODS"
                            },
                            new Item
                            {
                                Name = "Shoes",
                                Description = "Running, Size 10.5",
                                Sku = "sku02",
                                UnitAmount = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = "45.00"
                                },
                                Tax = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = "5.00"
                                },
                                Quantity = "2",
                                Category = "PHYSICAL_GOODS"
                            }
                        },
                        Shipping = new ShippingDetails
                        {
                            Name = new Name
                            {
                                FullName = "John Doe"
                            },
                            Address = new PortablePostalAddress
                            {
                                AddressLine1 = "123 Townsend St",
                                AddressLine2 = "Floor 6",
                                AdminArea2 = "San Francisco",
                                AdminArea1 = "CA",
                                PostalCode = "94107",
                                CountryCode = "US"
                            }
                        }
                    }
                }
            };

            return orderRequest;
        }

        //Below function can be used to create an order with complete payload.
        public async static Task<HttpResponse> CreateOrder(bool debug=false)
        {
            Console.WriteLine("Creating Order with complete payload");
            var request = new OrdersCreateRequest();
            request.Prefer("return=representation");
            request.RequestBody(BuildRequestBody());
            var response = await PayPalClient.client().Execute(request);
            var result = response.Result<Order>();
            if (debug)
            {
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Order Id: {0}", result.Id);
                Console.WriteLine("Intent: {0}", result.Intent);
                Console.WriteLine("Links:");
                foreach(LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }
                AmountWithBreakdown amount = result.PurchaseUnits[0].Amount;
                Console.WriteLine("Total Amount: {0} {1}", amount.CurrencyCode, amount.Value);
                Console.WriteLine("Response JSON: \n {0}", PayPalClient.ObjectToJSONString(result));
            }
            return response;
        }

        //Below function can be used to build the create order request body with minimum payload.
        private static OrderRequest BuildRequestBodyWithMinimumFields()
        {
            OrderRequest orderRequest = new OrderRequest()
            {
                Intent = "AUTHORIZE",
                ApplicationContext = new ApplicationContext
                {
                    CancelUrl = "https://www.example.com",
                    ReturnUrl = "https://www.example.com"
                },
                PurchaseUnits = new List<PurchaseUnitRequest>
                {
                    new PurchaseUnitRequest{
                        Amount = new AmountWithBreakdown
                        {
                            CurrencyCode = "USD",
                            Value = "220.00"
                        }
                        
                    }
                }
            };

            return orderRequest;
        }

        //Below function can be used to create an order with minimum payload.
        public async static Task<HttpResponse> CreateOrderWithMinimumFields(bool debug=false)
        {
            Console.WriteLine("Create Order with minimum payload..");
            var request = new OrdersCreateRequest();
            request.Headers.Add("prefer", "return=representation");
            request.RequestBody(BuildRequestBodyWithMinimumFields());
            var response = await PayPalClient.client().Execute(request);

            if (debug)
            {
                var result = response.Result<Order>();
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Order Id: {0}", result.Id);
                Console.WriteLine("Intent: {0}", result.Intent);
                Console.WriteLine("Links:");
                foreach(LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }
                AmountWithBreakdown amount = result.PurchaseUnits[0].Amount;
                Console.WriteLine("Total Amount: {0} {1}", amount.CurrencyCode, amount.Value);
            }

            return response;
        }

        // static void Main(string[] args)
        // {
        //    CreateOrder(true).Wait();
        //    CreateOrderWithMinimumFields(true).Wait();
        // }
    }
}
