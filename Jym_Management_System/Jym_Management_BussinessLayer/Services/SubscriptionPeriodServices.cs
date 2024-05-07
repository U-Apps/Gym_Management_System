using Jym_Management_BussinessLayer.AutoMapper;
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
    public class SubscriptionPeriodServices : IBaseServices<SubscriptionPeriod>
    {
        

        public int Add(SubscriptionPeriod module)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var tbSubsciptionPeriod = Mapping.Mapper.Map<TbSubsciptionPeriod>(module);
            repo.Add(tbSubsciptionPeriod);
            repo.SaveChanges(); 
            repo.Dispose();
            return tbSubsciptionPeriod.Id;
        }

        public void AddRange(IEnumerable<SubscriptionPeriod> module)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var tbSubsciptionPeriod = Mapping.Mapper.Map<IEnumerable<TbSubsciptionPeriod>>(module);
            repo.AddRange(tbSubsciptionPeriod);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void Delete(SubscriptionPeriod module)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var tbSubsciptionPeriod = Mapping.Mapper.Map<TbSubsciptionPeriod>(module);
            repo.Delete(tbSubsciptionPeriod);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void DeleteById(int id)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
           repo.DeleteById(c => c.Id == id);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void DeleteRange(IEnumerable<SubscriptionPeriod> modules)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var tbSubsciptionPeriod = Mapping.Mapper.Map<IEnumerable<TbSubsciptionPeriod>>(modules);
           repo.DeleteRange(tbSubsciptionPeriod);
            repo.SaveChanges(); 
            repo.Dispose();
            
        }

        public SubscriptionPeriod Find(Expression<Func<SubscriptionPeriod, bool>> predicate)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var exp = Mapping.Mapper.Map< Expression<Func<TbSubsciptionPeriod, bool>>>(predicate);
            return Mapping.Mapper.Map<SubscriptionPeriod>(repo.Find(exp));
        }

        public IEnumerable<SubscriptionPeriod> FindAll(Func<SubscriptionPeriod, bool> predicate)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbSubsciptionPeriod, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<SubscriptionPeriod>>(repo.FindAll(exp));
        }

        public IEnumerable<SubscriptionPeriod> GetAll()
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<SubscriptionPeriod>>(repo.GetAll());
        }

        public SubscriptionPeriod GetById(int id)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            return Mapping.Mapper.Map<SubscriptionPeriod>(repo.GetById(c => c.Id == id));
        }

        public void Update(SubscriptionPeriod module)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var tbSubsciptionPeriod = Mapping.Mapper.Map<TbSubsciptionPeriod>(module);
           repo.Update(tbSubsciptionPeriod);
            repo.SaveChanges();
            repo.Dispose();
           
        }
    }
}
