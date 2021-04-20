using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Logging;
using PayPal.Sdk.Checkout.Core.Interfaces;
using PayPal.Sdk.Checkout.Extensions;
using System;
using System.IO;
using Xunit;

[assembly: CollectionBehavior(MaxParallelThreads = -1)]

namespace PayPal.Sdk.Checkout.Test.Infrastructure
{
    public static class TestHttpClientFactory
    {
        private static IServiceProvider CreateServiceProvider()
        {
            var configurationBuilder = new ConfigurationBuilder();

            var currentDirectory = Directory.GetCurrentDirectory();
            configurationBuilder.SetBasePath(currentDirectory + "/../../..");
            configurationBuilder.AddJsonFile("appsettings.json5", optional: false, reloadOnChange: false);
            configurationBuilder.AddJsonFile("user.appsettings.json5", optional: true, reloadOnChange: false);
            configurationBuilder.AddEnvironmentVariables(prefix: "PAYPAL_");

            var configuration = configurationBuilder.Build();

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddPayPalCheckout(c => configuration.Bind(c));

            serviceCollection.AddLogging(loggingBuilder =>
            {
                loggingBuilder
                    .AddFilter("System.Net.Http.HttpClient.IPayPalHttpClient.RequestScope", LogLevel.Trace)
                    .AddFilter("System.Net.Http.HttpClient.IPayPalHttpClient.RequestLogger", LogLevel.Trace);

                loggingBuilder
                    .AddDebug()
                    .AddConsole();
            });

            serviceCollection.Replace(ServiceDescriptor.Singleton<IHttpMessageHandlerBuilderFilter, HttpClientLoggingFilter>());

            return serviceCollection.BuildServiceProvider();
        }

        public static IPayPalHttpClient CreateHttpClient()
        {
            var serviceProvider = CreateServiceProvider();

            return serviceProvider.GetRequiredService<IPayPalHttpClient>();
        }
    }
}
