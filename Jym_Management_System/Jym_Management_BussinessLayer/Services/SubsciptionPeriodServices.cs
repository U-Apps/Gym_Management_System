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
        

        public void Add(SubsciptionPeriod module)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var tbSubsciptionPeriod = Mapping.Mapper.Map<TbSubsciptionPeriod>(module);
            repo.Add(tbSubsciptionPeriod);
            repo.SaveChanges(); 
            repo.Dispose();
        }

        public void AddRange(IEnumerable<SubsciptionPeriod> module)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var tbSubsciptionPeriod = Mapping.Mapper.Map<IEnumerable<TbSubsciptionPeriod>>(module);
            repo.AddRange(tbSubsciptionPeriod);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void Delete(SubsciptionPeriod module)
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

        public void DeleteRange(IEnumerable<SubsciptionPeriod> modules)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var tbSubsciptionPeriod = Mapping.Mapper.Map<IEnumerable<TbSubsciptionPeriod>>(modules);
           repo.DeleteRange(tbSubsciptionPeriod);
            repo.SaveChanges(); 
            repo.Dispose();
            
        }

        public SubsciptionPeriod Find(Func<SubsciptionPeriod, bool> predicate)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbSubsciptionPeriod, bool>>(predicate);
            return Mapping.Mapper.Map<SubsciptionPeriod>(repo.Find(exp));
        }

        public IEnumerable<SubsciptionPeriod> FindAll(Func<SubsciptionPeriod, bool> predicate)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbSubsciptionPeriod, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<SubsciptionPeriod>>(repo.FindAll(exp));
        }

        public IEnumerable<SubsciptionPeriod> GetAll()
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<SubsciptionPeriod>>(repo.GetAll());
        }

        public SubsciptionPeriod GetById(int id)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            return Mapping.Mapper.Map<SubsciptionPeriod>(repo.GetById(c => c.Id == id));
        }

        public void Update(SubsciptionPeriod module)
        {
            IBaseRepository<TbSubsciptionPeriod> repo = new BaseRepository<TbSubsciptionPeriod>(new AppDbContext());
            var tbSubsciptionPeriod = Mapping.Mapper.Map<TbSubsciptionPeriod>(module);
           repo.Update(tbSubsciptionPeriod);
            repo.SaveChanges();
            repo.Dispose();
           
        }
    }
}
