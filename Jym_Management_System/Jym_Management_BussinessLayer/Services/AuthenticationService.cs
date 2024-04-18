using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_DataAccessLayer;
using Jym_Management_DataAccessLayer.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_BussinessLayer.Services
{
    public class AuthenticationService
    {
        AuthenticationManager Manager { get; }

        public AuthenticationService()
        {
            Manager = ServiceConfiguration.GetService<AuthenticationManager>();
        }

        public bool Login(string UserName, string Password)
        {
            return Manager.Login(UserName, Password);
        }
    }
}
