using Jym_Management_APIs.DTO_modules;
using Jym_Management_BussinessLayer.Services;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Jym_Management_APIs.Authentication
{
    public class LoginManager
    {
        private AuthenticationService _AuthenticationService { get; }
        private JwtOptions _JwtOptions { get; }
        private UserService _UserService { get; }


        public LoginManager(IOptions<JwtOptions> jwtOptions, AuthenticationService authenticationService, UserService userService)
        {
            _JwtOptions = jwtOptions.Value;
            _AuthenticationService = authenticationService;
            _UserService = userService;
        }
        private bool CheckCredentials(LoginDto Credentials)
        {
            return _AuthenticationService.Login(Credentials.UserName, Credentials.Password);
        }

        private ClaimsIdentity GetUserClaims(string UserName)
        {
            var Claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, UserName),
                new Claim(ClaimTypes.Role, UserName)
            };
            var Roles = _UserService.GetUserRoles(UserName);
            foreach(var role in Roles)
            {
                Claims.Add(new Claim(ClaimTypes.Role, role));
            }
            var Identity = new ClaimsIdentity(Claims);
            return Identity;
        }

        private string GenerateToken(string UserName)
        {
            var TokenHandler = new JwtSecurityTokenHandler();
            var TokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _JwtOptions.Issuer,
                Audience = _JwtOptions.Audience,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_JwtOptions.SigningKey))
                    , SecurityAlgorithms.HmacSha256),

                Subject = GetUserClaims(UserName)
            };

            var SecurityToken = TokenHandler.CreateToken(TokenDescriptor);
            var AccessToken = TokenHandler.WriteToken(SecurityToken);
            return AccessToken;
        }

        public LoginResponseDto Login(LoginDto Credentials)
        {            
            if (CheckCredentials(Credentials))
            {
                var Token = GenerateToken(Credentials.UserName);
                var Message = "تم تسجيل الدخول بنجاح";
                return new LoginResponseDto(true, Message, Token);
            }
            else
            {
                var Message = "اسم المستخدم أو كلمة المرور غير صحيحة";
                return new LoginResponseDto(false, Message, null);
            }
        }
    }
}
