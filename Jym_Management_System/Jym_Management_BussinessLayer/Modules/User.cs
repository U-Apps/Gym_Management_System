using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Modules
{
    public class User
    {
        public short UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int PersonId { get; set; }
        public bool IsActive { get; set; }
        public byte PermissionsId { get; set; }

        public virtual Permssion Permissions { get; set; } = null!;
        public virtual Person Person { get; set; } = null!;
    }
}
