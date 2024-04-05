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
    public class JobService : IBaseServices<Job>
    {

        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());
        public void Add(Job module)
        {
            var tbJob = Mapping.Mapper.Map<TbJob>(module);
            _unit.Jobs.Add(tbJob);
            if (_unit.Complete() == 0)
                return;
        }

        public void AddRange(IEnumerable<Job> module)
        {
            var tbJob = Mapping.Mapper.Map<IEnumerable<TbJob>>(module);
            _unit.Jobs.AddRange(tbJob);
            if(_unit.Complete() == 0)
                return;
        }

        public void Delete(Job module)
        {
            var tbJob = Mapping.Mapper.Map<TbJob>(module);
            _unit.Jobs.Delete(tbJob);
            if (_unit.Complete() == 0)
                return;
        }
        public void DeleteById(int id)
        {
            _unit.Jobs.DeleteById(id);
            if (_unit.Complete() == 0)
                return;

        }

        public void DeleteRange(IEnumerable<Job> modules)
        {
            var tbJob = Mapping.Mapper.Map<IEnumerable<TbJob>>(modules);
            _unit.Jobs.DeleteRange(tbJob);
            if (_unit.Complete() == 0)
                return;

        }

        public Job Find(Func<Job, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbJob, bool>>(predicate);
            return Mapping.Mapper.Map<Job>(_unit.Jobs.Find(exp));
        }

        public IEnumerable<Job> FindAll(Func<Job, bool> predicate)
        {

            var exp = Mapping.Mapper.Map<Func<TbJob, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Job>>(_unit.Jobs.FindAll(exp));
        }

        public IEnumerable<Job> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<Job>>(_unit.Jobs.GetAll());
        }

        public Job GetById(int id)
        {

            return Mapping.Mapper.Map<Job>(_unit.Jobs.GetById(id));

        }

        public void Update(Job module)
        {

            TbJob tbJob = Mapping.Mapper.Map<TbJob>(module);
            _unit.Jobs.Update(tbJob);
            if (_unit.Complete() == 0)
                return;
        }
    }

}
