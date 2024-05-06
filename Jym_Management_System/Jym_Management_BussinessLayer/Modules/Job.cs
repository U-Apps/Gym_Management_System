using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Modules
{
    public class Job
    {
      

        public byte JobId { get; set; }
        public string JobTitle { get; set; } = null!;

        public virtual ICollection<JobHistory> JobHistories { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
