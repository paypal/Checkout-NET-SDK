using PayPalCheckoutSdk.RequestInterfaces;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PayPalCheckoutSdk
{
    public abstract class BaseHttpRequest
    {
        public const string ApplicationJson = "application/json";
        public const string ApplicationXForm = "application/x-www-form-urlencoded";

        public HttpMethod Method { get; }

        public string Path { get; protected set; }

        public IDictionary<string, ICollection<string>> Headers { get; } = new Dictionary<string, ICollection<string>>();

        public AuthenticationHeaderValue? Authorization { get; protected set; }

        public string ContentType { get; protected set; } = null!;

        protected BaseHttpRequest(string path, HttpMethod method)
        {
            Path = path;
            Method = method;
        }
    }

    public abstract class BaseHttpRequest<TResponseType> : BaseHttpRequest, IPayPalRequestWithResponseBody<TResponseType>
    {
        protected BaseHttpRequest(string path, HttpMethod method) : base(path, method)
        {
        }
    }

    public abstract class BaseHttpRequest<TResponseType, TRequestBody> : BaseHttpRequest<TResponseType>, IPayPalRequestWithRequestBody<TRequestBody>
    {
        public TRequestBody Body { get; private set; } = default!;

        protected BaseHttpRequest(string path, HttpMethod method) : base(path, method)
        {
        }

        public void SetRequestBody(TRequestBody request)
        {
            Body = request;
        }
    }

    public abstract class BaseVoidHttpRequest<TRequestBody> : BaseHttpRequest, IPayPalRequestWithRequestBody<TRequestBody>
    {
        public TRequestBody Body { get; private set; } = default!;

        protected BaseVoidHttpRequest(string path, HttpMethod method) : base(path, method)
        {
        }

        public void SetRequestBody(TRequestBody request)
        {
            Body = request;
        }
    }
}
