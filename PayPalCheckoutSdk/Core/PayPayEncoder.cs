using PayPalCheckoutSdk.Core.Interfaces;
using PayPalCheckoutSdk.Core.MessageSerializers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace PayPalCheckoutSdk.Core
{
    public class PayPayEncoder : IPayPayEncoder
    {
        private readonly IReadOnlyCollection<IMessageSerializer> _messageSerializers;

        public PayPayEncoder()
        {
            _messageSerializers = new Collection<IMessageSerializer>
            {
                new FormEncodedSerializer(),
                new JsonSerializer(),
                new TextSerializer(),
            };
        }

        public async Task<HttpContent> SerializeRequestAsync<TRequestBody>(TRequestBody body, string contentType)
        {
            var serializer = _messageSerializers.FirstOrDefault(x => x.CanSerialize(body, contentType));

            if (serializer != null)
            {
                return await serializer.SerializeAsync(body, contentType);
            }

            throw new ArgumentException($"Not found serializer for message {contentType}");
        }

        public async Task<TResponse> DeserializeResponseAsync<TResponse>(HttpContent httpContent, MediaTypeHeaderValue mediaTypeHeaderValue, CancellationToken cancellationToken = default)
        {
            var serializer = _messageSerializers.FirstOrDefault(x => x.CanDeserialize<TResponse>(httpContent, mediaTypeHeaderValue));

            if (serializer != null)
            {
                return await serializer.DeserializeAsync<TResponse>(httpContent, mediaTypeHeaderValue);
            }

            throw new ArgumentException($"Not found serializer for message CharSet={mediaTypeHeaderValue.CharSet} MediaType={mediaTypeHeaderValue.MediaType}");
        }
    }
}
