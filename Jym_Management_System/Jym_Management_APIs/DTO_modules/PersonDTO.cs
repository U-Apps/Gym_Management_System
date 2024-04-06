using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadPersonDTO
    {
        public int PersonId { get; set; }
        public string? Idcard { get; set; }
        public string Name { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Email { get; set; }

    }

    public record UpdatePersonDTO
    {
        [Required]
        public int PersonId { get; set; }
        [Required]
        public string? Idcard { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required,Phone]
        public string? PhoneNumber { get; set; }
        [Required,]
        public DateTime BirthDate { get; set; }
        [Required , EmailAddress]
        public string? Email { get; set; }

    }

    public record CreatePersonDTO
    {
        [Required]
        public string? Idcard { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string? Email { get; set; }

    }
}
