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
    public class RoleService : IBaseServices<Role>
    {
        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());

        public void Add(Role module)
        {
            var tbRole = Mapping.Mapper.Map<TbRole>(module);
            _unit.Roles.Add(tbRole);
            if (_unit.Complete() == 0)
                return;
        }

        public void AddRange(IEnumerable<Role> module)
        {
            var tbRole = Mapping.Mapper.Map<IEnumerable<TbRole>>(module);
            _unit.Roles.AddRange(tbRole);
            if (_unit.Complete() == 0)
                return;
        }

        public void Delete(Role module)
        {
            var tbRole = Mapping.Mapper.Map<TbRole>(module);
            _unit.Roles.Delete(tbRole);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteById(int id)
        {
            _unit.Roles.DeleteById(id);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteRange(IEnumerable<Role> modules)
        {
            var tbRole = Mapping.Mapper.Map<IEnumerable<TbRole>>(modules);
            _unit.Roles.DeleteRange(tbRole);
            if (_unit.Complete() == 0)
                return;
        }

        public Role Find(Func<Role, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbRole, bool>>(predicate);
            return Mapping.Mapper.Map<Role>(_unit.Roles.Find(exp));
        }

        public IEnumerable<Role> FindAll(Func<Role, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbRole, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Role>>(_unit.Roles.FindAll(exp));
        }

        public IEnumerable<Role> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<Role>>(_unit.Roles.GetAll());
        }

        public Role GetById(int id)
        {
            return Mapping.Mapper.Map<Role>(_unit.Roles.GetById(id));
        }

        public void Update(Role module)
        {
            var tbRole = Mapping.Mapper.Map<TbRole>(module);
            _unit.Roles.Update(tbRole);
            if (_unit.Complete() == 0)
                return;
        }
    }
}
