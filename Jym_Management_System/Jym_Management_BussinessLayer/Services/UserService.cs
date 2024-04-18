using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
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
        private readonly UserRepository _UserRepository;

        public UserService()
        {
            _UserRepository = new UserRepository();
          
        }
        public void Register(User _UserModule)
        {
            AppUser appUser = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.Register(appUser, _UserModule.Password);
        }
        public void Delete(User _UserModule)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.Delete(user);
        }

        public void Update(User _UserModule)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.Update(user);

        }

        public List<User> GetAll()
        {
            return Mapping.Mapper.Map<List<User>>(_UserRepository.GetAll());
        }

        public User GetByUserName(string Username)
        {

            return Mapping.Mapper.Map<User>(_UserRepository.GetByUserName(Username));
        }

        public void AddUserToRole(User _UserModule, string role)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.AddUserToRole(user, role);
        }

        public void AddUserToRoles(User _UserModule, IEnumerable<string> roles)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.AddUserToRoles(user, roles);
        }
        public void RemoveUserToRole(User _UserModule, string role)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.RemoveUserToRole(user, role);
        }

        public void RemoveUserToRoles(User _UserModule, IEnumerable<string> roles)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.RemoveUserToRoles(user, roles);
        }

        public IEnumerable<string> GetUserRoles (string UserName)
        {
            return userRepository.GetUserRoles(UserName);
        }
    }
}

             
