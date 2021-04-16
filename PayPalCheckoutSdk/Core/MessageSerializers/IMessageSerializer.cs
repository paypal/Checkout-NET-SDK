using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PayPalCheckoutSdk.Core.MessageSerializers
{
    public interface IMessageSerializer
    {
        bool CanSerialize<TRequestBody>(TRequestBody body, string contentType);

        Task<HttpContent> SerializeAsync<TRequestBody>(TRequestBody body, string contentType);

        bool CanDeserialize<TResponse>(HttpContent response, MediaTypeHeaderValue contentType);

        Task<TResponse> DeserializeAsync<TResponse>(HttpContent response, MediaTypeHeaderValue contentType);
    }
}
