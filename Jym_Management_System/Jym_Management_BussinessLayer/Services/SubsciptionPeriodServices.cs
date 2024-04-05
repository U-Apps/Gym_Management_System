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
    public class SubsciptionPeriodServices : IBaseServices<SubsciptionPeriod>
    {
        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());

        public void Add(SubsciptionPeriod module)
        {
            var tbSubsciptionPeriod = Mapping.Mapper.Map<TbSubsciptionPeriod>(module);
            _unit.SubsciptionPeriods.Add(tbSubsciptionPeriod);
            if (_unit.Complete() == 0)
                return;
        }

        public void AddRange(IEnumerable<SubsciptionPeriod> module)
        {
            var tbSubsciptionPeriod = Mapping.Mapper.Map<IEnumerable<TbSubsciptionPeriod>>(module);
            _unit.SubsciptionPeriods.AddRange(tbSubsciptionPeriod);
            if (_unit.Complete() == 0)
                return;
        }

        public void Delete(SubsciptionPeriod module)
        {
            var tbSubsciptionPeriod = Mapping.Mapper.Map<TbSubsciptionPeriod>(module);
            _unit.SubsciptionPeriods.Delete(tbSubsciptionPeriod);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteById(int id)
        {
            _unit.SubsciptionPeriods.DeleteById(id);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteRange(IEnumerable<SubsciptionPeriod> modules)
        {
            var tbSubsciptionPeriod = Mapping.Mapper.Map<IEnumerable<TbSubsciptionPeriod>>(modules);
            _unit.SubsciptionPeriods.DeleteRange(tbSubsciptionPeriod);
            if (_unit.Complete() == 0)
                return;
        }

        public SubsciptionPeriod Find(Func<SubsciptionPeriod, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbSubsciptionPeriod, bool>>(predicate);
            return Mapping.Mapper.Map<SubsciptionPeriod>(_unit.SubsciptionPeriods.Find(exp));
        }

        public IEnumerable<SubsciptionPeriod> FindAll(Func<SubsciptionPeriod, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbSubsciptionPeriod, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<SubsciptionPeriod>>(_unit.SubsciptionPeriods.FindAll(exp));
        }

        public IEnumerable<SubsciptionPeriod> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<SubsciptionPeriod>>(_unit.SubsciptionPeriods.GetAll());
        }

        public SubsciptionPeriod GetById(int id)
        {
            return Mapping.Mapper.Map<SubsciptionPeriod>(_unit.SubsciptionPeriods.GetById(id));
        }

        public void Update(SubsciptionPeriod module)
        {
            var tbSubsciptionPeriod = Mapping.Mapper.Map<TbSubsciptionPeriod>(module);
            _unit.SubsciptionPeriods.Update(tbSubsciptionPeriod);
            if (_unit.Complete() == 0)
                return;
        }
    }
}
