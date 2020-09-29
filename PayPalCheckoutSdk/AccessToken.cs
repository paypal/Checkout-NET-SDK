using System;
using System.Runtime.Serialization;

namespace PayPalCheckoutSdk.Core
{
    [DataContract]
    public class AccessToken
    {
        [DataMember(Name = "access_token")]
        public string Token;

        [DataMember(Name = "token_type")]
        public string TokenType;

        [DataMember(Name = "expires_in")]
        public int ExpiresIn;

        private DateTime createDate;

        public AccessToken()
        {
            InitializeDefaults();
        }

        public bool IsExpired()
        {
            DateTime expireDate = this.createDate.Add(TimeSpan.FromSeconds(this.ExpiresIn));
            return DateTime.Now.CompareTo(expireDate) > 0;
        }

        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            InitializeDefaults();
        }

        private void InitializeDefaults()
        {
            createDate = DateTime.Now;
        }
    }
}
