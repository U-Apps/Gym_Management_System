using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
{
    public record LoginDto
        (
            [Required]
           [StringLength(30, MinimumLength = 4)]
            string UserName,
            [Required]
            [DataType(DataType.Password)]
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
