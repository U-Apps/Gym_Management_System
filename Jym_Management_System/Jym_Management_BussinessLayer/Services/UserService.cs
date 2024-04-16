using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_DataAccessLayer.Entities.Authentication;
using Jym_Management_DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_BussinessLayer.Services
{
    public class UserService
    {
        private readonly UserRepository userRepository;
        private readonly User UserModule;

        public UserService(User userModule)
        {
            userRepository = new UserRepository();
            UserModule = userModule;
        }
        public void Register(string passwoord)
        {
            AppUser appUser = Mapping.Mapper.Map<AppUser>(UserModule);
            userRepository.Register(appUser, passwoord);
        }
        public void Delete()
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(UserModule);
            userRepository.Delete(user);
        }

        public void Update()
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(UserModule);
            userRepository.Update(user);

        }

        public List<User> GetAll()
        {
            return Mapping.Mapper.Map<List<User>>(userRepository.GetAll());
        }

        public User GetByUserName(string userName)
        {

            return Mapping.Mapper.Map<User>(userRepository.GetByUserName(userName));
        }

        public void AddUserToRole(string role)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(UserModule);
            userRepository.AddUserToRole(user, role);
        }

        public void AddUserToRoles(IEnumerable<string> roles)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(UserModule);
            userRepository.AddUserToRoles(user, roles);
        }
        public void RemoveUserToRole(string role)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(UserModule);
            userRepository.RemoveUserToRole(user, role);
        }

        public void RemoveUserToRoles(IEnumerable<string> roles)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(UserModule);
            userRepository.RemoveUserToRoles(user, roles);
        }
    }
}

             
