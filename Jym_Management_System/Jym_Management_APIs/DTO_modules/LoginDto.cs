using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record LoginDto
        (
            [Required]
            string UserName,
            [Required]
            string Password
        );
    
    public record LoginResponseDto
        (
            [Required]
            bool LoginResult,
            string Message,
            string? Token
        );
}
