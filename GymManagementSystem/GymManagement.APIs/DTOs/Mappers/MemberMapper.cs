using GymManagement.BusinessCore.Models;

namespace GymManagement.APIs.DTOs.Mappers
{
    public static class MemberMapper
    {
        public static Member AsMember(this CreateMemberDTO dto)
        {
            var member = new Member();

            member.FirstName = dto.FirstName;
            member.SecondName = dto.SecondName;
            member.ThirdName = dto.ThirdName;
            member.LastName = dto.LastName;
            member.NationalNumber = dto.NationalNumber;
            member.PhoneNumber = dto.PhoneNumber;
            member.Email = dto.Email;
            member.Address = dto.Address;
            member.BirthDate = dto.BirthDate;
            member.MemberWeight = dto.MemberWeight;

            return member;
        }

    }
}
