using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PayPalCheckoutSdk.Core.MessageSerializers
{
    public class TextSerializer : IMessageSerializer
    {
        public bool CanSerialize<TRequestBody>(TRequestBody body, string contentType)
        {
            throw new System.NotImplementedException();
        }

        public Task<HttpContent> SerializeAsync<TRequestBody>(TRequestBody body, string contentType)
        {
            throw new System.NotImplementedException();
        }

        public bool CanDeserialize<TResponse>(HttpContent response, MediaTypeHeaderValue contentType)
        {
            throw new System.NotImplementedException();
        }

        public Task<TResponse> DeserializeAsync<TResponse>(HttpContent response, MediaTypeHeaderValue contentType)
        {
            throw new System.NotImplementedException();
        }
    }
}
