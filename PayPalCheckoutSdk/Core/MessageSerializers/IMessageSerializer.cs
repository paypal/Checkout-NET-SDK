using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace PayPalCheckoutSdk.Core.MessageSerializers
{
    public interface IMessageSerializer
    {
        bool CanSerialize<TRequestBody>(TRequestBody body, string contentType)
            where TRequestBody : notnull;

        Task<HttpContent> SerializeAsync<TRequestBody>(
            TRequestBody body, string contentType,
            CancellationToken cancellationToken
        )
            where TRequestBody : notnull;

        bool CanDeserialize<TResponse>(HttpContent response, MediaTypeHeaderValue contentType)
            where TResponse : notnull;

        Task<TResponse> DeserializeAsync<TResponse>(
            HttpContent response, MediaTypeHeaderValue contentType,
            CancellationToken cancellationToken
        )
            where TResponse : notnull;
    }
}
