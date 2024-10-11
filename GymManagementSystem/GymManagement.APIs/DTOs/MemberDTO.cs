using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
{
    public record ReadMemberDTO 
        (
            int MemberId,
            string FirstName,
            string SecondName,
            string ThirdName,
            string LastName,
            string? NationalNumber,
            string? PhoneNumber,
            DateTime? BirthDate,
            string? Address,
            string? Email,
            decimal? MemberWeight,
            bool IsActive,
            DateTime RegisterationDate
        );

    public record CreateMemberDTO
       (
            [Required]
             string FirstName,
            [Required]
             string SecondName,
             string ThirdName,
             [Required]
             string LastName,
            [Required]
            [DataType(DataType.CreditCard)]
             string? NationalNumber,

            [DataType(DataType.PhoneNumber)]
            string? PhoneNumber,
            [DataType(DataType.Date)]
            DateTime? BirthDate,
            string? Address,
            [Required]
            [EmailAddress]
            string? Email,
            [Range(1,200)]
            decimal? MemberWeight,
            [Required]
            CreateSubscriptionInfo SubscriptionInfo

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
            bool IsActive

      );
}
