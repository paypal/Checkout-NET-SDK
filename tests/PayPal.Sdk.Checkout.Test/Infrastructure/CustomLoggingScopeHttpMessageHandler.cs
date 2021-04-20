using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Test.Infrastructure
{
    public class HttpClientLoggingScopeHttpMessageHandler : DelegatingHandler
    {
        private readonly ILogger _scopeLogger;
        private readonly ILogger _requestLogger;

        public HttpClientLoggingScopeHttpMessageHandler(
            ILogger scopeLogger,
            ILogger requestLogger
        )
        {
            _scopeLogger = scopeLogger ?? throw new ArgumentNullException(nameof(scopeLogger));
            _requestLogger = requestLogger ?? throw new ArgumentNullException(nameof(requestLogger));
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var log = Log.BeginRequestPipelineScope(_scopeLogger, request);

            await log.RequestPipelineStart(_requestLogger, request);
            var response = await base.SendAsync(request, cancellationToken);
            await log.RequestPipelineEnd(_requestLogger, response);

            return response;
        }

        private class Log : IDisposable
        {
            private static class EventIds
            {
                public static readonly EventId PipelineStart = new(100, "RequestPipelineStart");
                public static readonly EventId PipelineEnd = new(101, "RequestPipelineEnd");
            }

            private static readonly Func<ILogger, HttpMethod, Uri?, string, IDisposable> BeginRequestPipelineScopeDefine = LoggerMessage.DefineScope<HttpMethod, Uri?, string>(
                "HTTP {HttpMethod} {Uri} {CorrelationId}"
            );

            private static readonly Action<ILogger, HttpMethod, Uri?, string, string?, Exception?> RequestPipelineStartDefine = LoggerMessage.Define<HttpMethod, Uri?, string, string?>(
                LogLevel.Trace,
                EventIds.PipelineStart,
                "Start processing HTTP request {HttpMethod} {Uri} [Correlation: {CorrelationId}]: {HttpContent}"
            );

            private static readonly Action<ILogger, HttpStatusCode, string?, Exception?> RequestPipelineEndDefine = LoggerMessage.Define<HttpStatusCode, string?>(
                LogLevel.Trace,
                EventIds.PipelineEnd,
                "End processing HTTP request - {StatusCode}: {HttpContent}"
            );

            private readonly IDisposable _loggerScope;

            private Log(IDisposable loggerScope)
            {
                _loggerScope = loggerScope;
            }

            public void Dispose()
            {
                _loggerScope.Dispose();
            }

            public static Log BeginRequestPipelineScope(ILogger logger, HttpRequestMessage request)
            {
                var correlationId = GetCorrelationIdFromRequest(request);

                var log = new Log(BeginRequestPipelineScopeDefine(logger, request.Method, request.RequestUri, correlationId));

                return log;
            }

            public async Task RequestPipelineStart(ILogger logger, HttpRequestMessage request)
            {
                var correlationId = GetCorrelationIdFromRequest(request);
                string? content = null;
                if (request.Content != null)
                {
                    content = await GetContent(request.Content);
                }

                RequestPipelineStartDefine(logger, request.Method, request.RequestUri, correlationId, content, null);
            }

            public async Task RequestPipelineEnd(ILogger logger, HttpResponseMessage response)
            {
                var content = await GetContent(response.Content);

                RequestPipelineEndDefine(logger, response.StatusCode, content, null);
            }

            private static string GetCorrelationIdFromRequest(HttpRequestMessage request)
            {
                var correlationId = "Not set";

                if (request.Headers.TryGetValues("X-Correlation-ID", out var values))
                {
                    correlationId = values.First();
                }

                return correlationId;
            }

            private async Task<string> GetContent(HttpContent httpContent)
            {
                if (httpContent.Headers.ContentEncoding.Contains("gzip"))
                {
                    var stream = await httpContent.ReadAsStreamAsync();
                    if (!stream.CanSeek)
                    {
                        return "<Stream content unknown - can not seek>";
                    }

                    await using var compressionStream = new GZipStream(
                        stream, CompressionMode.Decompress, leaveOpen: true
                    );

                    using var reader = new StreamReader(
                        compressionStream, Encoding.UTF8, detectEncodingFromByteOrderMarks: false, bufferSize: -1, leaveOpen: true
                    );
                    var content = await reader.ReadToEndAsync();

                    stream.Seek(0, SeekOrigin.Begin);

                    return content;
                }

                if (httpContent is MultipartFormDataContent multipartFormDataContent)
                {
                    var sb = new StringBuilder();
                    foreach (var innerContent in multipartFormDataContent)
                    {
                        var contentDisposition = innerContent.Headers.ContentDisposition;
                        sb.Append(contentDisposition);
                        sb.Append('\t');

                        var content = await GetContent(innerContent);

                        if (!string.IsNullOrEmpty(contentDisposition?.FileName))
                        {
                            content = content[..32];
                        }

                        sb.AppendLine(content);
                    }

                    return sb.ToString();
                }

                if (httpContent is StreamContent streamHttpContent)
                {
                    var streamContent = await streamHttpContent.ReadAsStreamAsync();

                    if (streamContent.CanSeek)
                    {
                        streamContent.Seek(0, SeekOrigin.Begin);

                        using var reader = new StreamReader(
                            streamContent, Encoding.UTF8, detectEncodingFromByteOrderMarks: false, bufferSize: -1, leaveOpen: true
                        );
                        var stringContent = await reader.ReadToEndAsync();

                        streamContent.Seek(0, SeekOrigin.Begin);

                        return stringContent;
                    }
                }

                return await httpContent.ReadAsStringAsync();
            }
        }
    }
}
