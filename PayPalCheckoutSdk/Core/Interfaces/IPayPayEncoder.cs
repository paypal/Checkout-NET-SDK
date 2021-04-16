using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace PayPalCheckoutSdk.Core.Interfaces
{
    public interface IPayPayEncoder
    {
        HttpContent SerializeRequest<TRequestBody>(TRequestBody body, string contentType);

        Task<TResponse> DeserializeResponse<TResponse>(
            HttpContent httpContent,
            MediaTypeHeaderValue mediaTypeHeaderValue,
            CancellationToken cancellationToken = default
        );
    }
}
