using GymManagement.BusinessCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.BusinessCore.DTOs.Mappers
{
    public static class MemberMapper
    {
        public static MemberResponse ToResponse(this Member member)
        {
            return new MemberResponse
            {
                MemberId = member.Id,
                FirstName = member.FirstName,
                SecondName = member.SecondName,
                ThirdName = member.ThirdName,
                LastName = member.LastName,
                NationalNumber = member.NationalNumber,
                PhoneNumber = member.PhoneNumber,
                Email = member.Email,
                Address = member.Address,
                BirthDate = member.BirthDate,
                MemberWeight = member.MemberWeight,
                IsActive = member.IsActive,
                RegisterationDate = member.RegisterationDate
            };
        }
    }
}

