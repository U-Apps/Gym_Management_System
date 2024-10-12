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

        public static void MapUpdatedPropertiesToMember(this UpdateMemberDTO UpdatedInfo, ref Member entity)
        {
            if (!string.IsNullOrWhiteSpace(UpdatedInfo.FirstName) && entity.FirstName != UpdatedInfo.FirstName)
                entity.FirstName = UpdatedInfo.FirstName;

            if (!string.IsNullOrWhiteSpace(UpdatedInfo.SecondName) && entity.SecondName != UpdatedInfo.SecondName)
                entity.SecondName = UpdatedInfo.SecondName;
            
            if (entity.ThirdName != UpdatedInfo.ThirdName)
                entity.ThirdName = string.IsNullOrEmpty(UpdatedInfo.ThirdName)?null:UpdatedInfo.ThirdName;

            if (!string.IsNullOrWhiteSpace(UpdatedInfo.LastName) && entity.LastName != UpdatedInfo.LastName)
                entity.LastName = UpdatedInfo.LastName;

            if (entity.NationalNumber != UpdatedInfo.NationalNumber)
                entity.NationalNumber = string.IsNullOrEmpty(UpdatedInfo.NationalNumber) ? null : UpdatedInfo.NationalNumber;

            if (entity.PhoneNumber != UpdatedInfo.PhoneNumber)
                entity.PhoneNumber = string.IsNullOrEmpty(UpdatedInfo.PhoneNumber) ? null : UpdatedInfo.PhoneNumber; ;
            
            if (entity.Email != UpdatedInfo.Email)
                entity.Email = string.IsNullOrEmpty(UpdatedInfo.Email) ? null : UpdatedInfo.Email;

            if (entity.Address != UpdatedInfo.Address)
                entity.Address = string.IsNullOrEmpty(UpdatedInfo.Address) ? null : UpdatedInfo.Address;

            if (entity.BirthDate != UpdatedInfo.BirthDate)
                entity.BirthDate = UpdatedInfo.BirthDate is null ? null : UpdatedInfo.BirthDate;

            if (entity.MemberWeight != UpdatedInfo.MemberWeight)
                entity.MemberWeight = UpdatedInfo.MemberWeight is null ? null : UpdatedInfo.MemberWeight;

            if (UpdatedInfo.IsActive != null && entity.IsActive != UpdatedInfo.IsActive)
                entity.IsActive = UpdatedInfo.IsActive.Value;

        }
    }
}

