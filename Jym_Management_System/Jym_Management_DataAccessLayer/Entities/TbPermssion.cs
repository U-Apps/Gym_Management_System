using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbPermssion
    {
        public TbPermssion()
        {
            TbUsers = new HashSet<TbUser>();
        }

        public byte Id { get; set; }
        public string? Name { get; set; }
        public byte? RoleId { get; set; }

        public virtual TbRole? Role { get; set; }
        public virtual ICollection<TbUser> TbUsers { get; set; }
    }
}
