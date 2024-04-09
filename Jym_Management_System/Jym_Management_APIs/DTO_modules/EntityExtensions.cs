using Jym_Management_BussinessLayer.Modules;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Collections.Generic;
using static Jym_Management_APIs.DTO_modules.ReadEmployeeDTO;

namespace Jym_Management_APIs.DTO_modules
{
    public static class EntityExtensions
    {
      

        public static ReadEmployeeDTO AsDTO(this Employee employee)
            => new ReadEmployeeDTO()
            {
                EmployeeId = employee.EmployeeId,
                Salary = employee.Salary,
                ResignationDate = employee.ResignationDate,
                HireDate = employee.HireDate,
                PersonId = employee.PersonId,

                person = new ReadPersonDTO()
                {
                    Name = employee.Person.Name,
                    PersonId = employee.PersonId,
                    Email=employee.Person.Email,
                    PhoneNumber=employee.Person.PhoneNumber,
                    BirthDate=employee.Person.BirthDate,
                    Idcard=employee.Person.Idcard
                },
                payments = employee.PayrollPayments.Select(employee => new ReadPaymnetsForEmployee { PaymentId=employee.PaymentId , PaymentDate = employee.PaymentDate}).ToList()

            };

        public static ReadMemberDTO AsDTO(this Member member)
            => new ReadMemberDTO
            (
                member.MemberId,
                member.PersonId,
                member.MemberWeight,
                member.IsActive,

                new ReadPersonDTO()
                {
                    Name = member.Person.Name,
                    PersonId = member.PersonId,
                    Email = member.Person.Email,
                    PhoneNumber = member.Person.PhoneNumber,
                    BirthDate = member.Person.BirthDate,
                    Idcard = member.Person.Idcard
                }
            );

        public static ReadUserDTO AsDTO(this User user)
            => new ReadUserDTO
            (
                user.UserId,
                user.UserName,
                user.Password,
                user.IsActive,
                PermissionsId:user.PermissionsId,

               Permissions: new ReadPermssionDTO
                (
                    Id :user.Permissions.Id,
                    Name:user.Permissions.Name,
                    Role:new ReadRoleDTO(
                        user.Permissions.Role.RoleId,
                        user.Permissions.Role.RoleName
                        )
                   
                ),
               Person: new ReadPersonDTO()
               {
                   Name = user.Person.Name,
                   PersonId = user.PersonId,
                   Email = user.Person.Email,
                   PhoneNumber = user.Person.PhoneNumber,
                   BirthDate = user.Person.BirthDate,
                   Idcard = user.Person.Idcard
               }
            );
        public static ReadPermssionDTO AsDTO(this Permssion permssion)
            => new ReadPermssionDTO
            (
                    Id: permssion.Id,
                    Name: permssion.Name,

                    Role: new ReadRoleDTO(
                        permssion.Role.RoleId,
                        permssion.Role.RoleName
                        )
                );

        public static ReadRoleDTO AsDTO(this Role role)
           => new ReadRoleDTO
           (
                  RoleId: role.RoleId,
                  RoleName: role.RoleName
               );

        public static ReadJobDTO AsDTO(this Job job)
          => new ReadJobDTO
          (
                 JobId: job.JobId,
                 JobTitle: job.JobTitle
              );

        public static ReadPeriodDTO AsDTO(this Period period)
         => new ReadPeriodDTO
         (
               PeriodId: period.PeriodId,
               PeriodName: period.PeriodName,
               StartTime: period.StartTime,
               EndTime: period.EndTime
             );
    }
}
