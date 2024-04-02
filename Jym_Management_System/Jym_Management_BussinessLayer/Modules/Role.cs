using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Modules
{
    public  class Role
    {
      

        public byte RoleId { get; set; }
        public string RoleName { get; set; } = null!;

        public virtual ICollection<Permssion> Permssions { get; set; }
    }
}
