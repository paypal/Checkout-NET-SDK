using PayPal.Sdk.Checkout.Core.Interfaces;
using Xunit;

[assembly: CollectionBehavior(MaxParallelThreads = -1)]

namespace PayPalCheckoutSdk.Test
{
    public class TestHarness
    {
        public static IPayPalHttpClient CreateHttpClient()
        {
        }
    }
}
