using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories;
using Jym_Management_DataAccessLayer.Repositories.Base;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class PermssionService : IBaseServices<Permssion>
    {
        

        public void Add(Permssion module)
        {
            IBaseRepository<TbPermssion> repo = new BaseRepository<TbPermssion>(new AppDbContext());
            var tbPermssion = Mapping.Mapper.Map<TbPermssion>(module);
            repo.Add(tbPermssion);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void AddRange(IEnumerable<Permssion> module)
        {
            IBaseRepository<TbPermssion> repo = new BaseRepository<TbPermssion>(new AppDbContext());
            var tbPermssion = Mapping.Mapper.Map<IEnumerable<TbPermssion>>(module);
            repo.AddRange(tbPermssion);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void Delete(Permssion module)
        {
            IBaseRepository<TbPermssion> repo = new BaseRepository<TbPermssion>(new AppDbContext());
            var tbPermssion = Mapping.Mapper.Map<TbPermssion>(module);
            repo.Delete(tbPermssion);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void DeleteById(int id)
        {
            IBaseRepository<TbPermssion> repo = new BaseRepository<TbPermssion>(new AppDbContext());
           repo.DeleteById(c => c.Id == id);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void DeleteRange(IEnumerable<Permssion> modules)
        {
            IBaseRepository<TbPermssion> repo = new BaseRepository<TbPermssion>(new AppDbContext());
            var tbPermssion = Mapping.Mapper.Map<IEnumerable<TbPermssion>>(modules);
           repo.DeleteRange(tbPermssion);
            repo.SaveChanges(); 
            repo.Dispose();
            
        }

        public Permssion Find(Func<Permssion, bool> predicate)
        {
            IBaseRepository<TbPermssion> repo = new BaseRepository<TbPermssion>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbPermssion, bool>>(predicate);
            return Mapping.Mapper.Map<Permssion>(repo.Find(exp));
        }

        public IEnumerable<Permssion> FindAll(Func<Permssion, bool> predicate)
        {
            IBaseRepository<TbPermssion> repo = new BaseRepository<TbPermssion>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbPermssion, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Permssion>>(repo.FindAll(exp));
        }

        public IEnumerable<Permssion> GetAll()
        {
            IBaseRepository<TbPermssion> repo = new BaseRepository<TbPermssion>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<Permssion>>(repo.GetAll(r=>r.Role));
        }

        public Permssion GetById(int id)
        {
            IBaseRepository<TbPermssion> repo = new BaseRepository<TbPermssion>(new AppDbContext());
            return Mapping.Mapper.Map<Permssion>(repo.GetById(c => c.Id == id,r=>r.Role));
        }

        public void Update(Permssion module)
        {
            IBaseRepository<TbPermssion> repo = new BaseRepository<TbPermssion>(new AppDbContext());
            TbPermssion tbPermssion = Mapping.Mapper.Map<TbPermssion>(module);
           repo.Update(tbPermssion);
            repo.SaveChanges();
            repo.Dispose();
            
        }
    }
}