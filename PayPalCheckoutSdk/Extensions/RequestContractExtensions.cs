using PayPalCheckoutSdk.ContractEnums;
using PayPalCheckoutSdk.RequestInterfaces;
using System;
using System.Collections.Generic;

namespace PayPalCheckoutSdk.Extensions
{
    public static class RequestContractExtensions
    {
        public static void Add(this IDictionary<string, ICollection<string>> collection, string key, string value)
        {
            if (!collection.ContainsKey(key))
            {
                collection.Add(key, new List<string>());
            }

            collection[key].Add(value);
        }

        public static TRequest SetPreferReturn<TRequest>(this TRequest request, EPreferReturn preferReturn)
            where TRequest : IConfigurePrefer
        {
            var preferValue = preferReturn switch
            {
                EPreferReturn.Minimal => "return=minimal",
                EPreferReturn.Representation => "return=representation",
                _ => throw new ArgumentOutOfRangeException(nameof(preferReturn), preferReturn, null)
            };

            request.Headers.Add("Prefer", preferValue);

            return request;
        }

        public static TRequest SetPayPalRequestId<TRequest>(this TRequest request, string payPalRequestId)
            where TRequest : IConfigurePayPalRequestId
        {
            request.Headers.Add("PayPal-Request-Id", payPalRequestId);

            return request;
        }

        public static TRequest SetPayPalClientMetadataId<TRequest>(this TRequest request, string payPalClientMetadataId)
            where TRequest : IConfigurePayPalMetadataId
        {
            request.Headers.Add("PayPal-Client-Metadata-Id", payPalClientMetadataId);

            return request;
        }

        public static TRequest SetPayPalPartnerAttributionId<TRequest>(this TRequest request, string payPalPartnerAttributionId)
            where TRequest : IConfigurePayPalMetadataId
        {
            request.Headers.Add("PayPal-Partner-Attribution-Id", payPalPartnerAttributionId);

            return request;
        }
    }
}
