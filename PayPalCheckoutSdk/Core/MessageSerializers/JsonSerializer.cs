using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NewtonsoftJsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace PayPalCheckoutSdk.Core.MessageSerializers
{
    public class JsonSerializer : IMessageSerializer
    {
        public const string ApplicationJson = "application/json";

        public bool CanSerialize<TRequestBody>(
            TRequestBody body, string contentType
        ) where TRequestBody : notnull => contentType == ApplicationJson;

        public async Task<HttpContent> SerializeAsync<TRequestBody>(
            TRequestBody body, string contentType,
            CancellationToken cancellationToken
        )
            where TRequestBody : notnull
        {
            var serializer = new NewtonsoftJsonSerializer();

            var memoryStream = new MemoryStream();
            await using var streamWriter = new StreamWriter(memoryStream, Encoding.UTF8, -1, leaveOpen: true);
            using var jsonTextWriter = new JsonTextWriter(streamWriter)
            {
                Formatting = Formatting.Indented,
                CloseOutput = false,
            };

            // ReSharper disable once HeapView.PossibleBoxingAllocation
            serializer.Serialize(jsonTextWriter, body, typeof(TRequestBody));

            memoryStream.Seek(0, SeekOrigin.Begin);

            var content = new StreamContent(memoryStream);
            content.Headers.ContentType = new MediaTypeHeaderValue(ApplicationJson)
            {
                CharSet = Encoding.UTF8.WebName,
            };

            return content;
        }

        public bool CanDeserialize<TResponse>(
            HttpContent response, MediaTypeHeaderValue contentType
        ) where TResponse : notnull => contentType.MediaType == ApplicationJson;

        public async Task<TResponse> DeserializeAsync<TResponse>(
            HttpContent response, MediaTypeHeaderValue contentType,
            CancellationToken cancellationToken
        )
            where TResponse : notnull
        {
            var stream = await response.ReadAsStreamAsync(
#if NET5_0
                cancellationToken
#endif
            );

            var serializer = new NewtonsoftJsonSerializer();

            using var streamReader = new StreamReader(stream);
            using var jsonTextReader = new JsonTextReader(streamReader);

            return serializer.Deserialize<TResponse>(jsonTextReader);
        }
    }
}
