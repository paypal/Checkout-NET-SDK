using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.ContractEnums;
using PayPal.Sdk.Checkout.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayPal.Sdk.Checkout.Extensions;
using PayPal.Sdk.Checkout.Orders;

namespace PayPal.Sdk.Checkout.Samples.CaptureIntentExamples
{
    public static class CreateOrderSample
    {
        /// <summary>
        /// Method to generate sample create order body with <b>CAPTURE</b> intent
        /// </summary>
        private static OrderRequest BuildRequestBody()
        {
            var orderRequest = new OrderRequest
            {
                CheckoutPaymentIntent = "CAPTURE",

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
                    new()
                    {
                        ReferenceId = "PUHF",
                        Description = "Sporting Goods",
                        CustomId = "CUST-HighFashions",
                        SoftDescriptor = "HighFashions",
                        AmountWithBreakdown = new AmountWithBreakdown
                        {
                            CurrencyCode = "USD",
                            Value = "220.00",
                            AmountBreakdown = new AmountBreakdown
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
                            new()
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
                            new()
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
                        ShippingDetail = new ShippingDetail
                        {
                            Name = new Name
                            {
                                FullName = "John Doe"
                            },
                            AddressPortable = new AddressPortable
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

        public static async Task<Order> CreateOrder(this PayPalHttpClient httpClient, AccessToken accessToken, bool debug = false)
        {
            var response = await httpClient.CreateOrderAsync(accessToken, request =>
            {
                request.SetPreferReturn(EPreferReturn.Representation);
                request.SetRequestBody(BuildRequestBody());
            });

            if (debug && response != null)
            {
                Console.WriteLine("Status: {0}", response.Status);
                Console.WriteLine("Order Id: {0}", response.Id);
                Console.WriteLine("Intent: {0}", response.CheckoutPaymentIntent);
                Console.WriteLine("Links:");
                foreach (var link in response.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }

                var amount = response.PurchaseUnits[0].AmountWithBreakdown;
                Console.WriteLine("Total Amount: {0} {1}", amount.CurrencyCode, amount.Value);
                Console.WriteLine("Response JSON: \n {0}", response.AsJson());
            }

            return response;
        }
        /*
             This is the driver function which invokes the createOrder function to create
             an sample order.
        */
        //static void Main(string[] args)
        //{
        //    CreateOrder(true).Wait();
        //}
    }
}
