using System;
using System.Text;

namespace PayPal.Sdk.Checkout.Configuration
{
    public class PayPalOptions
    {
        public string SandboxEndpoint { get; set; } = "https://api-m.paypal.com";

        public string LiveEndpoint { get; set; } = "https://api-m.sandbox.paypal.com";

        public EPayPalEnvironment Environment { get; set; } = EPayPalEnvironment.Sandbox;

        public string ClientId { get; set; } = null!;

        public string ClientSecret { get; set; } = null!;

        public TimeSpan Timeout { get; set; }

        public bool SendPayPalUserAgentHeader { get; set; } = true;

        public string BaseUrl => Environment == EPayPalEnvironment.Live
            ? LiveEndpoint
            : SandboxEndpoint;

        public string AuthorizationString() => Convert.ToBase64String(Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}"));
    }
}
