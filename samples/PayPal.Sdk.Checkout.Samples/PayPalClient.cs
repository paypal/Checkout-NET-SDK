using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayPal.Sdk.Checkout.Configuration;
using PayPal.Sdk.Checkout.Core;
using PayPal.Sdk.Checkout.Core.Interfaces;
using System;

namespace PayPal.Sdk.Checkout.Samples
{
    public class PayPalClient
    {
        public static IServiceProvider CreateServiceProvider()
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json5", optional: false, reloadOnChange: false);
            configurationBuilder.AddJsonFile("user.appsettings.json5", optional: true, reloadOnChange: false);

            var configuration = configurationBuilder.Build();

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddHttpClient<IPayPalHttpClient, PayPalHttpClient>();
            serviceCollection.AddScoped<PayPayEncoder>();
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
