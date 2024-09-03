using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Modules
{
    public class PayrollPayment
    {
        public int PaymentId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime PaymentDate { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
