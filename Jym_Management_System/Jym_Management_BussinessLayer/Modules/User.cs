using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Entities.Authentication;
using Jym_Management_DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Modules
{
    public class User
    {
        public int PersonId { get; set; }
        public bool IsActive { get; set; }
        public virtual TbPerson Person { get; set; } = null!;
    }
}
