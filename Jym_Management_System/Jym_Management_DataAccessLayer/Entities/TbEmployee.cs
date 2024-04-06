using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbEmployee
    {
        public TbEmployee()
        {
            TbPayrollPayments = new HashSet<TbPayrollPayment>();
        }

        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime ResignationDate { get; set; }
        public decimal Salary { get; set; }

        public virtual TbPerson Person { get; set; }
        public virtual ICollection<TbPayrollPayment> TbPayrollPayments { get; set; }
    }
}
