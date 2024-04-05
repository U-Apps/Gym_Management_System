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
    public class PeriodService : IBaseServices<Period>
    {
        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());

        public void Add(Period module)
        {
            var tbPeriod = Mapping.Mapper.Map<TbPeriod>(module);
            _unit.Periods.Add(tbPeriod);
            if (_unit.Complete() == 0)
                return;
        }

        public void AddRange(IEnumerable<Period> module)
        {
            var tbPeriod = Mapping.Mapper.Map<IEnumerable<TbPeriod>>(module);
            _unit.Periods.AddRange(tbPeriod);
            if (_unit.Complete() == 0)
                return;
        }

        public void Delete(Period module)
        {
            var tbPeriod = Mapping.Mapper.Map<TbPeriod>(module);
            _unit.Periods.Delete(tbPeriod);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteById(int id)
        {
            _unit.Periods.DeleteById(id);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteRange(IEnumerable<Period> modules)
        {
            var tbPeriod = Mapping.Mapper.Map<IEnumerable<TbPeriod>>(modules);
            _unit.Periods.DeleteRange(tbPeriod);
            if (_unit.Complete() == 0)
                return;
        }

        public Period Find(Func<Period, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbPeriod, bool>>(predicate);
            return Mapping.Mapper.Map<Period>(_unit.Periods.Find(exp));
        }

        public IEnumerable<Period> FindAll(Func<Period, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbPeriod, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Period>>(_unit.Periods.FindAll(exp));
        }

        public IEnumerable<Period> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<Period>>(_unit.Periods.GetAll());
        }

        public Period GetById(int id)
        {
            return Mapping.Mapper.Map<Period>(_unit.Periods.GetById(id));
        }

        public void Update(Period module)
        {
            TbPeriod tbPeriod = Mapping.Mapper.Map<TbPeriod>(module);
            _unit.Periods.Update(tbPeriod);
            if (_unit.Complete() == 0)
                return;
        }
    }
}
