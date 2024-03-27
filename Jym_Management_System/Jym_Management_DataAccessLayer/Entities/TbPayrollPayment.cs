using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbPayrollPayment
    {
        public int PaymentId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime PaymentDate { get; set; }

        public virtual TbEmployee Employee { get; set; } = null!;
    }
}
