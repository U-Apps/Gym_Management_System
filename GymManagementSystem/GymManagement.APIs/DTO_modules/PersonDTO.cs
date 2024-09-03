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
        [DataType(DataType.CreditCard)]
        public string? Idcard { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6 )]
        public string Name { get; set; } = null!;
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

    }

    public record CreatePersonDTO
    {
        [Required]
        [DataType(DataType.CreditCard)]
        public string? Idcard { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string Name { get; set; } = null!;
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

    }
}
