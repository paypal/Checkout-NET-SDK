using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PayPalCheckoutSdk.Configuration;
using PayPalCheckoutSdk.Core;
using PayPalCheckoutSdk.Core.Interfaces;
using System;
using System.Net;
using System.Net.Http;

namespace PayPalCheckoutSdk.Extensions
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddPayPalCheckout(
            this IServiceCollection services,
            Action<PayPalOptions>? configure = null
        )
        {
            if (configure != null)
            {
                services.Configure(configure);
            }

            services.AddScoped<IPayPayEncoder, PayPayEncoder>();

            services.AddHttpClient<IPayPalHttpClient, PayPalHttpClient>((serviceProvider, httpClient) =>
                {
                    var payPalOptions = serviceProvider.GetRequiredService<IOptions<PayPalOptions>>().Value;

                    httpClient.Timeout = payPalOptions.Timeout;
                    httpClient.BaseAddress = new Uri(payPalOptions.BaseUrl);

                    if (payPalOptions.SendPayPalUserAgentHeader)
                    {
                        httpClient.DefaultRequestHeaders.Add("User-Agent", UserAgent.GetUserAgentHeader());
                    }
                })
                .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
                {
                    AllowAutoRedirect = false,
                    AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
                });

            return services;
        }
    }
}
