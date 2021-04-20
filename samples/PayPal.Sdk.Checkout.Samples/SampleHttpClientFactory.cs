using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayPal.Sdk.Checkout.Core.Interfaces;
using PayPal.Sdk.Checkout.Extensions;
using System;
using System.IO;

namespace PayPal.Sdk.Checkout.Samples
{
    public static class SampleHttpClientFactory
    {
        private static IServiceProvider CreateServiceProvider()
        {
            var configurationBuilder = new ConfigurationBuilder();

            var currentDirectory = Directory.GetCurrentDirectory();
            configurationBuilder.SetBasePath(currentDirectory + "/../../..");
            configurationBuilder.AddJsonFile("appsettings.json5", optional: false, reloadOnChange: false);
            configurationBuilder.AddJsonFile("user.appsettings.json5", optional: true, reloadOnChange: false);

            var configuration = configurationBuilder.Build();

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddPayPalCheckout(c => configuration.Bind(c));

            return serviceCollection.BuildServiceProvider();
        }

        public static IPayPalHttpClient CreateHttpClient()
        {
            var serviceProvider = CreateServiceProvider();

            return serviceProvider.GetRequiredService<IPayPalHttpClient>();
        }
    }
}
