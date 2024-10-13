using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
{
    public record CreateMemberDTO
       (
            [Required]
             string FirstName,
            [Required]
             string SecondName,
             string ThirdName,
             [Required]
             string LastName,
             string? NationalNumber,

            [DataType(DataType.PhoneNumber)]
            string? PhoneNumber,
            [DataType(DataType.Date)]
            DateTime? BirthDate,
            string? Address,
            [EmailAddress]
            string? Email,
            [Range(1,200)]
            decimal? MemberWeight,
            [Required]
            CreateSubscriptionInfo SubscriptionInfo

       );
}
