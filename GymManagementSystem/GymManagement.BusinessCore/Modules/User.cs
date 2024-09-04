using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Entities.Authentication;
using Jym_Management_DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace GymManagement.BussinessCore.Modules
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PersonId { get; set; }
        public bool IsActive { get; set; }
        public virtual Person Person { get; set; } = null!;
    }
}
