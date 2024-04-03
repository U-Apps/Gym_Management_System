using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Modules
{
    public class Permssion
    {
        
        public byte Id { get; set; }
        public string? Name { get; set; }
        public byte? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
