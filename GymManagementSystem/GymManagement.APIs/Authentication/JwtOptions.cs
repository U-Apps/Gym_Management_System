namespace Jym_Management_APIs.Authentication
{
    public class JwtOptions
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double Lifetime { get; set; }
        public string SigningKey { get; set; }
    }
}
