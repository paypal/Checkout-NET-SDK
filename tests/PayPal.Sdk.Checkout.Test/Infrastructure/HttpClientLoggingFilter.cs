using Microsoft.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;

namespace PayPal.Sdk.Checkout.Test.Infrastructure
{
    public class HttpClientLoggingFilter : IHttpMessageHandlerBuilderFilter
    {
        private readonly ILoggerFactory _loggerFactory;

        public HttpClientLoggingFilter(
            ILoggerFactory loggerFactory
        )
        {
            _loggerFactory = loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory));
        }

        public Action<HttpMessageHandlerBuilder> Configure(Action<HttpMessageHandlerBuilder> next)
        {
            if (next == null)
            {
                throw new ArgumentNullException(nameof(next));
            }

            return builder =>
            {
                // Run other configuration first, we want to decorate.
                next(builder);

                var name = builder.Name;
                var i = name.IndexOf(',');
                if (i > 0)
                {
                    name = name.Substring(0, name.IndexOf(','));
                }

                var scopeLogger = _loggerFactory.CreateLogger($"System.Net.Http.HttpClient.{name}.RequestScope");
                var requestLogger = _loggerFactory.CreateLogger($"System.Net.Http.HttpClient.{name}.RequestLogger");

                builder.AdditionalHandlers.Insert(0, new HttpClientLoggingScopeHttpMessageHandler(
                    scopeLogger,
                    requestLogger
                ));
            };
        }
    }
}
