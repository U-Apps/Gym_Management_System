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
    public class RoleService : IBaseServices<Role>
    {
        
        public void Add(Role module)
        {
            IBaseRepository<TbRole> repo = new BaseRepository<TbRole>(new AppDbContext());
            var tbRole = Mapping.Mapper.Map<TbRole>(module);
           repo.Add(tbRole);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void AddRange(IEnumerable<Role> module)
        {
            IBaseRepository<TbRole> repo = new BaseRepository<TbRole>(new AppDbContext());
            var tbRole = Mapping.Mapper.Map<IEnumerable<TbRole>>(module);
           repo.AddRange(tbRole);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void Delete(Role module)
        {
            IBaseRepository<TbRole> repo = new BaseRepository<TbRole>(new AppDbContext());
            var tbRole = Mapping.Mapper.Map<TbRole>(module);
           repo.Delete(tbRole);
            repo.SaveChanges() ;
            repo.Dispose();
          
        }

        public void DeleteById(int id)
        {
            IBaseRepository<TbRole> repo = new BaseRepository<TbRole>(new AppDbContext());
            repo.DeleteById(id);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void DeleteRange(IEnumerable<Role> modules)
        {
            IBaseRepository<TbRole> repo = new BaseRepository<TbRole>(new AppDbContext());
            var tbRole = Mapping.Mapper.Map<IEnumerable<TbRole>>(modules);
           repo.DeleteRange(tbRole);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public Role Find(Func<Role, bool> predicate)
        {
            IBaseRepository<TbRole> repo = new BaseRepository<TbRole>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbRole, bool>>(predicate);
            return Mapping.Mapper.Map<Role>(repo.Find(exp));
        }

        public IEnumerable<Role> FindAll(Func<Role, bool> predicate)
        {
            IBaseRepository<TbRole> repo = new BaseRepository<TbRole>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbRole, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Role>>(repo.FindAll(exp));
        }

        public IEnumerable<Role> GetAll()
        {
            IBaseRepository<TbRole> repo = new BaseRepository<TbRole>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<Role>>(repo.GetAll());
        }

        public Role GetById(int id)
        {
            IBaseRepository<TbRole> repo = new BaseRepository<TbRole>(new AppDbContext());
            return Mapping.Mapper.Map<Role>(repo.GetById(id));
        }

        public void Update(Role module)
        {
            IBaseRepository<TbRole> repo = new BaseRepository<TbRole>(new AppDbContext());
            var tbRole = Mapping.Mapper.Map<TbRole>(module);
            repo.Update(tbRole);
            repo.SaveChanges();
            repo.Dispose();
            
        }
    }
}
