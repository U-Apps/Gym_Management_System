using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbRole
    {
        public TbRole()
        {
            TbPermssions = new HashSet<TbPermssion>();
        }

        public byte RoleId { get; set; }
        public string RoleName { get; set; } = null!;

        public virtual ICollection<TbPermssion> TbPermssions { get; set; }
    }
}
