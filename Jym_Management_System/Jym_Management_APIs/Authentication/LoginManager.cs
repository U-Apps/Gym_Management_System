using Jym_Management_APIs.DTO_modules;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Jym_Management_APIs.Authentication
{
    public class LoginManager
    {
        private JwtOptions _JwtOptions { get; }

        public LoginManager(JwtOptions jwtOptions)
        {
            _JwtOptions = jwtOptions;
        }
        private bool CheckCredentials(LoginDto Credentials)
        {
            // not implemeneted yet
            return false;
        }

        private ClaimsIdentity GetUserClaims()
        {
            //not implemeneted yet
            return null;
        }

        private string GenerateToken()
        {
            var TokenHandler = new JwtSecurityTokenHandler();
            var TokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _JwtOptions.Issuer,
                Audience = _JwtOptions.Audience,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_JwtOptions.SigningKey))
                    , SecurityAlgorithms.HmacSha256),

                Subject = GetUserClaims()
            };

            var SecurityToken = TokenHandler.CreateToken(TokenDescriptor);
            var AccessToken = TokenHandler.WriteToken(SecurityToken);
            return AccessToken;
        }

        public LoginResponseDto Login(LoginDto Credentials)
        {            
            if (CheckCredentials(Credentials))
            {
                var Token = GenerateToken();
                return new LoginResponseDto(true, Token);
            }
            else
            {
                return new LoginResponseDto(false, null);
            }
        }
    }
}
