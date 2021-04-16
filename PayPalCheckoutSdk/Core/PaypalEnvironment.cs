using System;
using System.Text;

namespace PayPalCheckoutSdk.Core
{
    /// <summary>
    /// Recommended to use SandboxEnvironment for testing or LiveEnvironment for production.
    /// </summary>
    public class PayPalEnvironment
    {
        private readonly string _baseUrl;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _webUrl;

        public PayPalEnvironment(string clientId, string clientSecret, string baseUrl, string webUrl)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _baseUrl = baseUrl;
            _webUrl = webUrl;
        }

        public string BaseUrl()
        {
            return _baseUrl;
        }

        public string AuthorizationString()
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_clientId}:{_clientSecret}"));
        }

        public string ClientId()
        {
            return _clientId;
        }

        public string WebUrl()
        {
            return _webUrl;
        }
    }

    /// <summary>
    /// Environment used for sandbox testing.
    /// </summary>
    public class SandboxEnvironment : PayPalEnvironment
    {
        public SandboxEnvironment(string clientId, string clientSecret) : base(clientId, clientSecret, "https://api.sandbox.paypal.com", "https://www.sandbox.paypal.com")
        {
        }
    }

    /// <summary>
    /// Environment used for production.
    /// </summary>
    public class LiveEnvironment : PayPalEnvironment
    {
        public LiveEnvironment(string clientId, string clientSecret) : base(clientId, clientSecret, "https://api.paypal.com", "https://www.paypal.com")
        {
        }
    }
}
