using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class UserServices : IBaseServices<User>
    {
        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());


        public void Add(User module)
        {
            var tbUser = Mapping.Mapper.Map<TbUser>(module);
            _unit.Users.Add(tbUser);
            if (_unit.Complete() == 0)
                return;
        }

        public void AddRange(IEnumerable<User> module)
        {
            var tbUser = Mapping.Mapper.Map<IEnumerable<TbUser>>(module);
            _unit.Users.AddRange(tbUser);
            if (_unit.Complete() == 0)
                return;
        }

        public void Delete(User module)
        {
            var tbUser = Mapping.Mapper.Map<TbUser>(module);
            _unit.Users.Delete(tbUser);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteById(int id)
        {
            _unit.Users.DeleteById(id);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteRange(IEnumerable<User> modules)
        {
            var tbUser = Mapping.Mapper.Map<IEnumerable<TbUser>>(modules);
            _unit.Users.DeleteRange(tbUser);
            if (_unit.Complete() == 0)
                return;
        }

        public User Find(Func<User, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbUser, bool>>(predicate);
            return Mapping.Mapper.Map<User>(_unit.Users.Find(exp));
        }

        public IEnumerable<User> FindAll(Func<User, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbUser, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<User>>(_unit.Users.FindAll(exp));
        }

        public IEnumerable<User> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<User>>(_unit.Users.GetAll());
        }

        public User GetById(int id)
        {
            return Mapping.Mapper.Map<User>(_unit.Users.GetById(id));
        }

        public void Update(User module)
        {
            var tbUser = Mapping.Mapper.Map<TbUser>(module);
            _unit.Users.Update(tbUser);
            if (_unit.Complete() == 0)
                return;
        }
    }
}
