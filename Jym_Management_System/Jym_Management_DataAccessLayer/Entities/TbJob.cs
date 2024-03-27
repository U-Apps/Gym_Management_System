using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbJob
    {
        public TbJob()
        {
            TbJobHistories = new HashSet<TbJobHistory>();
        }

        public byte JobId { get; set; }
        public string JobTitle { get; set; } = null!;

        public virtual ICollection<TbJobHistory> TbJobHistories { get; set; }
    }
}
