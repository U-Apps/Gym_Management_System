using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbUser
    {
        public short UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int PersonId { get; set; }
        public bool IsActive { get; set; }
        public byte PermissionsId { get; set; }

        public virtual TbPermssion Permissions { get; set; } = null!;
        public virtual TbPerson Person { get; set; } = null!;
    }
}
