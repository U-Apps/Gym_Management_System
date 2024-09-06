using System;
using System.Collections.Generic;

namespace GymManagement.DataAccess.Entities
{
    public partial class TbJob
    {
        public TbJob()
        {
            TbJobHistories = new HashSet<TbJobHistory>();
            TbEmployees = new HashSet<TbEmployee>();
        }

        public byte JobId { get; set; }
        public string JobTitle { get; set; } = null!;

        public virtual ICollection<TbJobHistory> TbJobHistories { get; set; }
        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
