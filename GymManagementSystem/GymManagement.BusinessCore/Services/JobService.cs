﻿using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories;
using Jym_Management_DataAccessLayer.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Jym_Management_BussinessLayer.Services
{
    public class JobService : IBaseServices<Job>
    {

       
        public int Add(Job module)
        {
            IBaseRepository<TbJob> repo = new BaseRepository<TbJob>(new AppDbContext());

            var tbJob = Mapping.Mapper.Map<TbJob>(module);
           repo.Add(tbJob);
            repo.SaveChanges();
            repo.Dispose();
            return tbJob.JobId;
        }

        public void AddRange(IEnumerable<Job> module)
        {
            IBaseRepository<TbJob> repo = new BaseRepository<TbJob>(new AppDbContext());
            var tbJob = Mapping.Mapper.Map<IEnumerable<TbJob>>(module);
           repo.AddRange(tbJob);
            
        }

        public void Delete(Job module)
        {
            IBaseRepository<TbJob> repo = new BaseRepository<TbJob>(new AppDbContext());
            var tbJob = Mapping.Mapper.Map<TbJob>(module);
           repo.Delete(tbJob);
            repo.SaveChanges();
            repo.Dispose();
            
        }
        public void DeleteById(int id)
        {
            IBaseRepository<TbJob> repo = new BaseRepository<TbJob>(new AppDbContext());
            repo.DeleteById(c=>c.JobId==id);
            repo.SaveChanges();
          repo.Dispose();

        }

        public void DeleteRange(IEnumerable<Job> modules)
        {
            IBaseRepository<TbJob> repo = new BaseRepository<TbJob>(new AppDbContext());
            var tbJob = Mapping.Mapper.Map<IEnumerable<TbJob>>(modules);
           repo.DeleteRange(tbJob);
            repo.SaveChanges();
            repo.Dispose();

        }

        public Job Find(Expression<Func<Job, bool>> predicate)
        {
            IBaseRepository<TbJob> repo = new BaseRepository<TbJob>(new AppDbContext());
            var exp = Mapping.Mapper.Map< Expression<Func<TbJob, bool>>>(predicate);
            return Mapping.Mapper.Map<Job>(repo.Find(exp));
        }

        public IEnumerable<Job> FindAll(Func<Job, bool> predicate)
        {
            IBaseRepository<TbJob> repo = new BaseRepository<TbJob>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbJob, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Job>>(repo.FindAll(exp));
        }

        public IEnumerable<Job> GetAll()
        {
            IBaseRepository<TbJob> repo = new BaseRepository<TbJob>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<Job>>(repo.GetAll());
        }

        public Job GetById(int id)
        {
            IBaseRepository<TbJob> repo = new BaseRepository<TbJob>(new AppDbContext());
            return Mapping.Mapper.Map<Job>(repo.GetById(c => c.JobId == id));

        }

        public void Update(Job module)
        {
            IBaseRepository<TbJob> repo = new BaseRepository<TbJob>(new AppDbContext());
            TbJob tbJob = Mapping.Mapper.Map<TbJob>(module);
           repo.Update(tbJob);
            repo.SaveChanges();
            repo.Dispose();
            
        }
    }

}
