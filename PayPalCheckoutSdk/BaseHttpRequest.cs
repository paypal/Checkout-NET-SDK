using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PayPalCheckoutSdk
{
    public abstract class BaseHttpRequest
    {
        public const string ApplicationJson = "application/json";

        public string Path { get; protected set; }

        public HttpMethod Method { get; protected set; }

        public IDictionary<string, ICollection<string>> Headers { get; } = new Dictionary<string, ICollection<string>>();

        public AuthenticationHeaderValue? Authorization { get; protected set; }

        public string ContentType { get; protected set; } = null!;

        public string ContentEncoding { get; protected set; }

        public Type ResponseType { get; protected set; }

        protected BaseHttpRequest(string path, HttpMethod method)
        {
            ResponseType = typeof(void);
            Path = path;
            Method = method;
            ContentEncoding = "identity";
        }
    }

    public abstract class BaseHttpRequest<TResponseType> : BaseHttpRequest
    {
        protected BaseHttpRequest(string path, HttpMethod method) : base(path, method)
        {
            ResponseType = typeof(TResponseType);
        }
    }

    public abstract class BaseHttpRequest<TResponseType, TRequestType> : BaseHttpRequest<TResponseType>
    {
        public TRequestType Body { get; protected set; } = default!;

        protected BaseHttpRequest(string path, HttpMethod method) : base(path, method)
        {
        }

        public BaseHttpRequest<TResponseType, TRequestType> RequestBody(TRequestType request)
        {
            Body = request;

            return this;
        }
    }

    public abstract class BaseVoidHttpRequest<TRequestType> : BaseHttpRequest
    {
        public TRequestType Body { get; protected set; } = default!;

        protected BaseVoidHttpRequest(string path, HttpMethod method) : base(path, method)
        {
        }

        public BaseVoidHttpRequest<TRequestType> RequestBody(TRequestType request)
        {
            Body = request;

            return this;
        }
    }
}
