using Jym_Management_BussinessLayer.Modules;

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
                PersonId = employee.PersonId
            };
    }
}
