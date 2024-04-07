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
    }
}
