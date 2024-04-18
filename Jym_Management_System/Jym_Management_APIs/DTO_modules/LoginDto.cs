using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record LoginDto
        (
            [Required]
           [StringLength(30, MinimumLength = 6)]
            string UserName,
            [Required]
            [DataType(DataType.Password)]
            string Password
        );
    
    public record LoginResponseDto
        (
            [Required]
            bool LoginResult,
            string? Token
        );
}
