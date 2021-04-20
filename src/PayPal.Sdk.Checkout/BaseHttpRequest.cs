using PayPal.Sdk.Checkout.RequestInterfaces;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PayPal.Sdk.Checkout
{
    public abstract class BaseHttpRequest
    {
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
        where TResponseType : notnull
    {
        protected BaseHttpRequest(string path, HttpMethod method) : base(path, method)
        {
        }
    }

    public abstract class BaseHttpRequest<TResponseType, TRequestBody> : BaseHttpRequest<TResponseType>, IPayPalRequestWithRequestBody<TRequestBody>
        where TResponseType : notnull
        where TRequestBody : notnull
    {
        public TRequestBody Body { get; private set; } = default!;

        protected BaseHttpRequest(string path, HttpMethod method) : base(path, method)
        {
        }

        // ReSharper disable once MemberCanBeProtected.Global
        public void SetRequestBody(TRequestBody request)
        {
            Body = request;
        }
    }

    public abstract class BaseVoidHttpRequest<TRequestBody> : BaseHttpRequest, IPayPalRequestWithRequestBody<TRequestBody>
        where TRequestBody : notnull
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
