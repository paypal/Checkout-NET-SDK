using System;
using System.Net;
using System.Net.Http.Headers;

namespace PayPalCheckoutSdk.Core
{
    public class PayPalHttpException : Exception
    {
        public HttpStatusCode ResponseStatusCode { get; }

        public HttpResponseHeaders ResponseHeaders { get; }

        public string ResponseBodyContent { get; }

        public PayPalHttpException(
            HttpStatusCode responseStatusCode,
            HttpResponseHeaders responseHeaders,
            string responseBodyContent
        ) : base(responseStatusCode.ToString())
        {
            ResponseStatusCode = responseStatusCode;
            ResponseHeaders = responseHeaders;
            ResponseBodyContent = responseBodyContent;
        }
    }
}
