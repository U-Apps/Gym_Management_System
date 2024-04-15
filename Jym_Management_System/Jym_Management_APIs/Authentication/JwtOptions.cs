namespace Jym_Management_APIs.Authentication
{
    public class JwtOptions
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Lifetime { get; set; }
        public string SigningKey { get; set; }
    }
}
