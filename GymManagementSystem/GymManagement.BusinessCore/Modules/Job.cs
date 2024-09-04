using System;
using System.Collections.Generic;

namespace GymManagement.BussinessCore.Modules
{
    public class Job
    {
      

        public byte JobId { get; set; }
        public string JobTitle { get; set; } = null!;

        public virtual ICollection<JobHistory> JobHistories { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
