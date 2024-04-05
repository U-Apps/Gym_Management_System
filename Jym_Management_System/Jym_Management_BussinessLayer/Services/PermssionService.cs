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
    public class PermssionService : IBaseServices<Permssion>
    {
        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());

        public void Add(Permssion module)
        {
            var tbPermssion = Mapping.Mapper.Map<TbPermssion>(module);
            _unit.Permssions.Add(tbPermssion);
            if (_unit.Complete() == 0)
                return;
        }

        public void AddRange(IEnumerable<Permssion> module)
        {
            var tbPermssion = Mapping.Mapper.Map<IEnumerable<TbPermssion>>(module);
            _unit.Permssions.AddRange(tbPermssion);
            if (_unit.Complete() == 0)
                return;
        }

        public void Delete(Permssion module)
        {
            var tbPermssion = Mapping.Mapper.Map<TbPermssion>(module);
            _unit.Permssions.Delete(tbPermssion);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteById(int id)
        {
            _unit.Permssions.DeleteById(id);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteRange(IEnumerable<Permssion> modules)
        {
            var tbPermssion = Mapping.Mapper.Map<IEnumerable<TbPermssion>>(modules);
            _unit.Permssions.DeleteRange(tbPermssion);
            if (_unit.Complete() == 0)
                return;
        }

        public Permssion Find(Func<Permssion, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbPermssion, bool>>(predicate);
            return Mapping.Mapper.Map<Permssion>(_unit.Permssions.Find(exp));
        }

        public IEnumerable<Permssion> FindAll(Func<Permssion, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbPermssion, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Permssion>>(_unit.Permssions.FindAll(exp));
        }

        public IEnumerable<Permssion> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<Permssion>>(_unit.Permssions.GetAll());
        }

        public Permssion GetById(int id)
        {
            return Mapping.Mapper.Map<Permssion>(_unit.Permssions.GetById(id));
        }

        public void Update(Permssion module)
        {
            TbPermssion tbPermssion = Mapping.Mapper.Map<TbPermssion>(module);
            _unit.Permssions.Update(tbPermssion);
            if (_unit.Complete() == 0)
                return;
        }
    }
}