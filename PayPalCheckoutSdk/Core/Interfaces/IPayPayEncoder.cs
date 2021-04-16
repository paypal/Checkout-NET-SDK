using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace PayPalCheckoutSdk.Core.Interfaces
{
    public interface IPayPayEncoder
    {
        Task<HttpContent> SerializeRequestAsync<TRequestBody>(TRequestBody body, string contentType);

        Task<TResponse> DeserializeResponseAsync<TResponse>(
            HttpContent httpContent,
            MediaTypeHeaderValue mediaTypeHeaderValue,
            CancellationToken cancellationToken = default
        );
    }
}
