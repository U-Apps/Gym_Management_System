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
    public class UserServices : IBaseServices<User>
    {

        public void Add(User module)
        {
            IBaseRepository<TbUser> repo = new BaseRepository<TbUser>(new AppDbContext());
            var tbUser = Mapping.Mapper.Map<TbUser>(module);
           repo.Add(tbUser);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void AddRange(IEnumerable<User> module)
        {
            IBaseRepository<TbUser> repo = new BaseRepository<TbUser>(new AppDbContext());
            var tbUser = Mapping.Mapper.Map<IEnumerable<TbUser>>(module);
            repo.AddRange(tbUser);
            repo.SaveChanges(); 
            repo.Dispose();
           
        }

        public void Delete(User module)
        {
            IBaseRepository<TbUser> repo = new BaseRepository<TbUser>(new AppDbContext());
            var tbUser = Mapping.Mapper.Map<TbUser>(module);
            repo.Delete(tbUser);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void DeleteById(int id)
        {
            IBaseRepository<TbUser> repo = new BaseRepository<TbUser>(new AppDbContext());
           repo.DeleteById(c=>c.UserId==id);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void DeleteRange(IEnumerable<User> modules)
        {
            IBaseRepository<TbUser> repo = new BaseRepository<TbUser>(new AppDbContext());
            var tbUser = Mapping.Mapper.Map<IEnumerable<TbUser>>(modules);
            repo.DeleteRange(tbUser);
            repo.SaveChanges(); 
            repo.Dispose();
            
        }

        public User Find(Func<User, bool> predicate)
        {
            IBaseRepository<TbUser> repo = new BaseRepository<TbUser>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbUser, bool>>(predicate);
            return Mapping.Mapper.Map<User>(repo.Find(exp));
        }

        public IEnumerable<User> FindAll(Func<User, bool> predicate)
        {
            IBaseRepository<TbUser> repo = new BaseRepository<TbUser>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbUser, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<User>>(repo.FindAll(exp));
        }

        public IEnumerable<User> GetAll()
        {
            IBaseRepository<TbUser> repo = new BaseRepository<TbUser>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<User>>(repo.GetAll(
                    perm=>perm.Permissions,
                    perm => perm.Permissions.Role,
                    prsn =>prsn.Person
                    ));
        }

        public User GetById(int id)
        {
            IBaseRepository<TbUser> repo = new BaseRepository<TbUser>(new AppDbContext());
            return Mapping.Mapper.Map<User>(repo.GetById(c=>c.UserId==id, perm => perm.Permissions, prsn => prsn.Person));
        }

        public void Update(User module)
        {
            IBaseRepository<TbUser> repo = new BaseRepository<TbUser>(new AppDbContext());
            var tbUser = Mapping.Mapper.Map<TbUser>(module);
            repo.Update(tbUser);
            repo.SaveChanges(); 
            repo.Dispose();
        }
    }
}
