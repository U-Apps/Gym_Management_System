using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
{
    public record ReadMemberDTO 
        (
              int MemberId,
              int PersonId ,
              decimal? MemberWeight ,
              bool? IsActive ,

              ReadPersonDTO Person
        
        );

    public record CreateMemberDTO
       (
            [Required]
            [DataType(DataType.CreditCard)]
             string? Idcard,
            [Required]
            [StringLength(50, MinimumLength = 6)]
            string Name,
            [Required]
            [DataType(DataType.PhoneNumber)]
            string? PhoneNumber,
            [Required]
            [DataType(DataType.Date)]
            DateTime BirthDate,
            [Required]
            [EmailAddress]
            string? Email,
             [Range(1,200)]
             decimal? MemberWeight,
             bool? IsActive

       );

    public record UpdateMemberDTO
      (
            [Required]
            [DataType(DataType.CreditCard)]
             string? Idcard,
            [Required]
            [StringLength(50, MinimumLength = 6)]
            string Name,
            [Required]
            [DataType(DataType.PhoneNumber)]
            string? PhoneNumber,
            [Required]
            [DataType(DataType.Date)]
            DateTime BirthDate,
            [Required]
            [EmailAddress]
            string? Email,
            [Required]
             int MemberId,
            [Range(1,200)]
             decimal? MemberWeight,
            bool? IsActive

      );
}
