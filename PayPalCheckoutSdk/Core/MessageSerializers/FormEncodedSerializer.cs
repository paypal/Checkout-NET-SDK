using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace PayPalCheckoutSdk.Core.MessageSerializers
{
    public class FormEncodedSerializer : IMessageSerializer
    {
        public const string ApplicationXForm = "application/x-www-form-urlencoded";

        public bool CanSerialize<TRequestBody>(
            TRequestBody body, string contentType
        ) where TRequestBody : notnull => contentType == ApplicationXForm;

        public Task<HttpContent> SerializeAsync<TRequestBody>(
            TRequestBody body, string contentType,
            CancellationToken cancellationToken
        )
            where TRequestBody : notnull
        {
            if (body is IDictionary<string?, string?> dictionary)
            {
                return Task.FromResult((HttpContent) new FormUrlEncodedContent(dictionary));
            }

            throw new ArgumentException("Request requestBody must be IDictionary<string, string> when Content-Type is application/x-www-form-urlencoded");
        }

        public bool CanDeserialize<TResponse>(
            HttpContent response, MediaTypeHeaderValue contentType
        ) where TResponse : notnull => false;

        public Task<TResponse> DeserializeAsync<TResponse>(
            HttpContent response, MediaTypeHeaderValue contentType,
            CancellationToken cancellationToken
        )
            where TResponse : notnull
        {
            throw new NotSupportedException($"{nameof(FormEncodedSerializer)}.{nameof(DeserializeAsync)} is not supported");
        }
    }
}
