// This class was generated on Fri, 15 Feb 2019 15:03:18 PST by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// OrdersGetRequest.cs
// @version 0.1.0-dev+8fcb5f
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// Shows details for an order, by ID.
    /// </summary>
    public class OrdersGetRequest : HttpRequest
    {
        public OrdersGetRequest(string OrderId) : base("/v2/checkout/orders/{order_id}?", HttpMethod.Get, typeof(Order))
        {
            try {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        public OrdersGetRequest Authorization(string Authorization) 
        {
            this.Headers.Add("Authorization", Authorization);
            return this;
        }
        
        public OrdersGetRequest ContentType(string ContentType) 
        {
            this.Headers.Add("Content-Type", ContentType);
            return this;
        }
        
        
    }
}
