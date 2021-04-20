using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Authentication
{
    [DataContract]
    public class RefreshToken
    {
        [DataMember(Name = "refresh_token")]
        public string Token { get; set; } = null!;

        [DataMember(Name = "token_type")]
        public string TokenType { get; set; } = null!;

        [DataMember(Name = "expires_in")]
        public string ExpiresIn { get; set; } = null!;

        [DataMember(Name = "id_token")]
        public string IdToken { get; set; } = null!;
    }
}
