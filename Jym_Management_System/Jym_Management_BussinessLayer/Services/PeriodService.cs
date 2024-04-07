using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class PeriodService : IBaseServices<Period>
    {
       

        public void Add(Period module)
        {
            IBaseRepository<TbPeriod> repo = new BaseRepository<TbPeriod>(new AppDbContext());
            var tbPeriod = Mapping.Mapper.Map<TbPeriod>(module);
            repo.Add(tbPeriod);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void AddRange(IEnumerable<Period> module)
        {
            IBaseRepository<TbPeriod> repo = new BaseRepository<TbPeriod>(new AppDbContext());
            var tbPeriod = Mapping.Mapper.Map<IEnumerable<TbPeriod>>(module);
            repo.AddRange(tbPeriod);
            repo.SaveChanges();
              repo.Dispose();

            
        }

        public void Delete(Period module)
        {
            IBaseRepository<TbPeriod> repo = new BaseRepository<TbPeriod>(new AppDbContext());
            var tbPeriod = Mapping.Mapper.Map<TbPeriod>(module);
            repo.Delete(tbPeriod);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void DeleteById(int id)
        {
            IBaseRepository<TbPeriod> repo = new BaseRepository<TbPeriod>(new AppDbContext());
            repo.DeleteById(c => c.PeriodId == id);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void DeleteRange(IEnumerable<Period> modules)
        {
            IBaseRepository<TbPeriod> repo = new BaseRepository<TbPeriod>(new AppDbContext());
            var tbPeriod = Mapping.Mapper.Map<IEnumerable<TbPeriod>>(modules);
            repo.DeleteRange(tbPeriod);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public Period Find(Func<Period, bool> predicate)
        {
            IBaseRepository<TbPeriod> repo = new BaseRepository<TbPeriod>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbPeriod, bool>>(predicate);
            return Mapping.Mapper.Map<Period>(repo.Find(exp));
        }

        public IEnumerable<Period> FindAll(Func<Period, bool> predicate)
        {
            IBaseRepository<TbPeriod> repo = new BaseRepository<TbPeriod>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbPeriod, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Period>>(repo.FindAll(exp));
        }

        public IEnumerable<Period> GetAll()
        {
            IBaseRepository<TbPeriod> repo = new BaseRepository<TbPeriod>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<Period>>(repo.GetAll());
        }

        public Period GetById(int id)
        {
            IBaseRepository<TbPeriod> repo = new BaseRepository<TbPeriod>(new AppDbContext());
            return Mapping.Mapper.Map<Period>(repo.GetById(c => c.PeriodId == id));
        }

        public void Update(Period module)
        {
            IBaseRepository<TbPeriod> repo = new BaseRepository<TbPeriod>(new AppDbContext());
            TbPeriod tbPeriod = Mapping.Mapper.Map<TbPeriod>(module);
           repo.Update(tbPeriod);
           repo.SaveChanges();
            repo.Dispose();
        }
    }
}
