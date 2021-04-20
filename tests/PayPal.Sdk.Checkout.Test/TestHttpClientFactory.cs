using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayPal.Sdk.Checkout.Configuration;
using PayPal.Sdk.Checkout.Core;
using PayPal.Sdk.Checkout.Core.Interfaces;
using System;
using System.IO;
using Xunit;

[assembly: CollectionBehavior(MaxParallelThreads = -1)]

namespace PayPal.Sdk.Checkout.Test
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

            serviceCollection.AddHttpClient<IPayPalHttpClient, PayPalHttpClient>();
            serviceCollection.AddScoped<IPayPayEncoder, PayPayEncoder>();
            serviceCollection.Configure<PayPalOptions>(c => configuration.Bind(c));

            return serviceCollection.BuildServiceProvider();
        }

        public static IPayPalHttpClient CreateHttpClient()
        {
            var serviceProvider = CreateServiceProvider();

            return serviceProvider.GetRequiredService<IPayPalHttpClient>();
        }
    }
}
