using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Jym_Management_BussinessLayer.Modules
{
    public class Employee
    {
       
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime ResignationDate { get; set; }
        public decimal Salary { get; set; }
        public byte? JobID { get; set; }

        public virtual Person Person { get; set; }
        public virtual Job CurrentJob { get; set; }

        public virtual ICollection<PayrollPayment> PayrollPayments { get; set; }
        public virtual ICollection<JobHistory> EmployeementHistory { get; set; }

    }
}
