
namespace GymManagement.BusinessCore.Models
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public DateTime? ResignationDate { get; set; }
        public byte? JobID { get; set; }

        public virtual Job CurrentJob { get; set; }
        public virtual ICollection<PayrollPayment>? PayrollPayments { get; set; }
        public virtual ICollection<JobHistory> EmployeementHistory { get; set; }

        //public Employee()
        //{
        //    Salary = -1;
        //    ResignationDate = null;
        //    JobID = null;
        //}

        //public Employee(int id, string firstName, string secondName,
        //    string thirdName, string lastName, string? nationalNumber,
        //    string? phoneNumber, DateTime? birthDate, string? email,
        //    string? address, DateTime registerationDate,
        //    decimal salary, DateTime? resignationDate, byte? jobID)
            
        //    :base(id, firstName, secondName,
        //     thirdName, lastName, nationalNumber,
        //     phoneNumber, birthDate, email, address, registerationDate)
        //{
        //    Salary = salary;
        //    ResignationDate = resignationDate;
        //    JobID = jobID;
        //}
    }
}
