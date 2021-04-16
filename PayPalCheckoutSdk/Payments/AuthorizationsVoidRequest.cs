// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// AuthorizationsVoidRequest.cs
// @version 0.1.0-dev+904328-dirty
// @type request
// @data H4sIAAAAAAAC/2yS0YpTMRCG732KYa5jz7J4lTvZKruI7tGWBZFFpifTPdE0iZPJYix9dzltFVt7++XPMP/HbPEDbRgtUtUxif9F6lMss+fkHRqccxnE54mhxYfkXTGQBAaKA4digCL8+ckOMrUNRzWwanA3n8HnVKdoTArTwMtp0JEURiqwYo6wriE0GChrFXYzNPixsrSehDasLAXtl0eDt0yO5Zy+TbI5Zz3peMK2uGx56lxUfHxCgw8knlaBL7n4uhfxjtvx8T8ry5Ghp9ZTePnEkYWUHdzNYZ0EdOSLjdPex1TutQi1wz5XBj8xufsYGto1hcIT+FG9sEOrUtlgLymzqOeCNtYQdo+HDBc9DJnghEpOsfC/7CZF5XiMIeUc/LBv2H0rKaLBW9X8nnVMDi3294slHuShxe75ujsuX7rTU+m257p23fF6Ft99/tvkzc/Mg7JbKGktN8kx2uurV7sXvwEAAP//
// DO NOT EDIT

using PayPalCheckoutSdk.Core.MessageSerializers;
using System;
using System.IO;
using System.Net.Http;


namespace PayPalCheckoutSdk.Payments
{
    /// <summary>
    /// Voids, or cancels, an authorized payment, by ID. You cannot void an authorized payment that has been fully captured.
    /// </summary>
    public class AuthorizationsVoidRequest : BaseHttpRequest
    {
        public AuthorizationsVoidRequest(string authorizationId) : base("/v2/payments/authorizations/{authorization_id}/void?", HttpMethod.Post)
        {
            try
            {
                Path = Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(authorizationId)));
            }
            catch (IOException)
            {
            }

            ContentType = JsonSerializer.ApplicationJson;
        }
    }
}
