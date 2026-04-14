using GymManagement.BusinessCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.BusinessCore.DTOs
{
    public record MemberResponse
    {
        public int MemberId { get; init; }
        public string FirstName { get; init; }
        public string SecondName { get; init; }
        public string? ThirdName { get; init; }
        public string LastName { get; init; }
        public string? NationalNumber { get; init; }
        public string? PhoneNumber { get; init; }
        public DateTime? BirthDate { get; init; }
        public string? Address { get; init; }
        public string? Email { get; init; }
        public decimal? MemberWeight { get; init; }
        public bool IsActive { get; init; }
        public DateTime RegisterationDate { get; init; }
    }

    public record UpdateMemberDTO
      (
            string? FirstName,
            string? SecondName,
            string? ThirdName,
            string? LastName,
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
            bool? IsActive
      );

    public record CreateMemberDTO
       (
            [Required]
             string FirstName,
            [Required]
             string SecondName,
             string? ThirdName,
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
