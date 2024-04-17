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
        private readonly UserRepository _UserRepository;
        private readonly User _UserModule;

        public UserService(User userModule)
        {
            _UserRepository = new UserRepository();
            _UserModule = userModule;
        }
        public void Register()
        {
            AppUser appUser = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.Register(appUser, _UserModule.Password);
        }
        public void Delete()
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.Delete(user);
        }

        public void Update()
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.Update(user);

        }

        public List<User> GetAll()
        {
            return Mapping.Mapper.Map<List<User>>(_UserRepository.GetAll());
        }

        public User GetByUserName()
        {

            return Mapping.Mapper.Map<User>(_UserRepository.GetByUserName(_UserModule.UserName));
        }

        public void AddUserToRole(string role)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.AddUserToRole(user, role);
        }

        public void AddUserToRoles(IEnumerable<string> roles)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.AddUserToRoles(user, roles);
        }
        public void RemoveUserToRole(string role)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.RemoveUserToRole(user, role);
        }

        public void RemoveUserToRoles(IEnumerable<string> roles)
        {
            AppUser user = Mapping.Mapper.Map<AppUser>(_UserModule);
            _UserRepository.RemoveUserToRoles(user, roles);
        }
    }
}

             
