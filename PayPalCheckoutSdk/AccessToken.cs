using System;
using System.Runtime.Serialization;

namespace PayPalCheckoutSdk
{
    [DataContract]
    public class AccessToken
    {
        [DataMember(Name = "access_token")]
        public string Token { get; set; } = null!;

        [DataMember(Name = "token_type")]
        public string TokenType { get; set; } = null!;

        [DataMember(Name = "expires_in")]
        public int ExpiresIn { get; set; }

        private DateTime ReceivedDate { get; set; }

        public AccessToken(DateTime? now = null)
        {
            ReceivedDate = now ?? DateTime.Now;
        }

        public bool IsExpired(DateTime? now = null)
        {
            var expireDate = ReceivedDate.Add(TimeSpan.FromSeconds(ExpiresIn));

            now ??= DateTime.Now;

            return now.Value.CompareTo(expireDate) > 0;
        }
    }
}
