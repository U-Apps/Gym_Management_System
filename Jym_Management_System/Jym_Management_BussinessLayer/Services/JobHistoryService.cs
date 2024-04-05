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
    public class JobHistoryService : IBaseServices<JobHistory>
    {
 
     

        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());

        public void Add(JobHistory module)
        {
            var tbJobHistory = Mapping.Mapper.Map<TbJobHistory>(module);
            _unit.JobHistories.Add(tbJobHistory);
        }

        public void AddRange(IEnumerable<JobHistory> module)
        {
            var tbJobHistory = Mapping.Mapper.Map<IEnumerable<TbJobHistory>>(module);
            _unit.JobHistories.AddRange(tbJobHistory);
        }

        public void Delete(JobHistory module)
        {
            var tbJobHistory = Mapping.Mapper.Map<TbJobHistory>(module);
            _unit.JobHistories.Delete(tbJobHistory);
        }

        public void DeleteById(int id)
        {
            _unit.JobHistories.DeleteById(id);
            int x = _unit.Complete();
        }

        public void DeleteRange(IEnumerable<JobHistory> modules)
        {
            var tbJobHistory = Mapping.Mapper.Map<IEnumerable<TbJobHistory>>(modules);
            _unit.JobHistories.DeleteRange(tbJobHistory);
        }

        public JobHistory Find(Func<JobHistory, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbJobHistory, bool>>(predicate);
            return Mapping.Mapper.Map<JobHistory>(_unit.JobHistories.Find(exp));
        }

        public IEnumerable<JobHistory> FindAll(Func<JobHistory, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbJobHistory, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<JobHistory>>(_unit.JobHistories.FindAll(exp));
        }

        public IEnumerable<JobHistory> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<JobHistory>>(_unit.JobHistories.GetAll());
        }

        public JobHistory GetById(int id)
        {
            return Mapping.Mapper.Map<JobHistory>(_unit.JobHistories.GetById(id));
        }

        public void Update(JobHistory module)
        {
            _unit.JobHistories.Update(Mapping.Mapper.Map<TbJobHistory>(module));
        }
    }
}
