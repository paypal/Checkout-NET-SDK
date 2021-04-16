using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace PayPalCheckoutSdk.Core.MessageSerializers
{
    public class JsonSerializer : IMessageSerializer
    {
        public const string ApplicationJson = "application/json";

        public bool CanSerialize<TRequestBody>(
            TRequestBody body, string contentType
        ) => contentType == ApplicationJson;

        public async Task<HttpContent> SerializeAsync<TRequestBody>(TRequestBody body, string contentType)
        {
            await using var memoryStream = new MemoryStream();

            var dataContractJsonSerializer = new DataContractJsonSerializer(typeof(TRequestBody));
            dataContractJsonSerializer.WriteObject(memoryStream, body);

            memoryStream.Seek(0, SeekOrigin.Begin);

            var content = new StreamContent(memoryStream);
            content.Headers.ContentType = new MediaTypeHeaderValue(ApplicationJson)
            {
                CharSet = Encoding.UTF8.WebName,
            };

            return content;
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
