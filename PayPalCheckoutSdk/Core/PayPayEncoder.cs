using PayPalCheckoutSdk.Core.Interfaces;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace PayPalCheckoutSdk.Core
{
    public class PayPayEncoder : IPayPayEncoder
    {
        public HttpContent SerializeRequest<TRequestBody>(TRequestBody body, string contentType)
        {
            throw new System.NotImplementedException();
        }

        public Task<TResponse> DeserializeResponse<TResponse>(HttpContent httpContent, MediaTypeHeaderValue mediaTypeHeaderValue, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
