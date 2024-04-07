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
 
        public void Add(JobHistory module)
        {
            IBaseRepository<TbJobHistory> repo = new BaseRepository<TbJobHistory>(new AppDbContext());
            var tbJobHistory = Mapping.Mapper.Map<TbJobHistory>(module);
            repo.Add(tbJobHistory);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void AddRange(IEnumerable<JobHistory> module)
        {
            IBaseRepository<TbJobHistory> repo = new BaseRepository<TbJobHistory>(new AppDbContext());
            var tbJobHistory = Mapping.Mapper.Map<IEnumerable<TbJobHistory>>(module);
            repo.AddRange(tbJobHistory);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void Delete(JobHistory module)
        {
            IBaseRepository<TbJobHistory> repo = new BaseRepository<TbJobHistory>(new AppDbContext());
            var tbJobHistory = Mapping.Mapper.Map<TbJobHistory>(module);
            repo.Delete(tbJobHistory);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void DeleteById(int id)
        {
            IBaseRepository<TbJobHistory> repo = new BaseRepository<TbJobHistory>(new AppDbContext());
            repo.DeleteById(c=>c.Id==id);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void DeleteRange(IEnumerable<JobHistory> modules)
        {
            IBaseRepository<TbJobHistory> repo = new BaseRepository<TbJobHistory>(new AppDbContext());
            var tbJobHistory = Mapping.Mapper.Map<IEnumerable<TbJobHistory>>(modules);
            repo.DeleteRange(tbJobHistory);
            repo.SaveChanges();
            repo.Dispose();
        }

        public JobHistory Find(Func<JobHistory, bool> predicate)
        {
            IBaseRepository<TbJobHistory> repo = new BaseRepository<TbJobHistory>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbJobHistory, bool>>(predicate);
            return Mapping.Mapper.Map<JobHistory>(repo.Find(exp));
        }

        public IEnumerable<JobHistory> FindAll(Func<JobHistory, bool> predicate)
        {
            IBaseRepository<TbJobHistory> repo = new BaseRepository<TbJobHistory>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbJobHistory, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<JobHistory>>(repo.FindAll(exp));
        }

        public IEnumerable<JobHistory> GetAll()
        {
            IBaseRepository<TbJobHistory> repo = new BaseRepository<TbJobHistory>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<JobHistory>>(repo.GetAll());
        }

        public JobHistory GetById(int id)
        {
            IBaseRepository<TbJobHistory> repo = new BaseRepository<TbJobHistory>(new AppDbContext());
            return Mapping.Mapper.Map<JobHistory>(repo.GetById(c=>c.Id==id));
        }

        public void Update(JobHistory module)
        {
            IBaseRepository<TbJobHistory> repo = new BaseRepository<TbJobHistory>(new AppDbContext());
            repo.Update(Mapping.Mapper.Map<TbJobHistory>(module));
            repo.SaveChanges();
            repo.Dispose();
        }
    }
}
