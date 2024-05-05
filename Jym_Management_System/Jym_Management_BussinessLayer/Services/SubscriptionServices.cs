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
    public class SubscriptionServices : IBaseServices<Subscription>
    {

        public int Add(Subscription module)
        {
            IBaseRepository<TbSubscription> repo = new BaseRepository<TbSubscription>(new AppDbContext());
            var tbSubscription = Mapping.Mapper.Map<TbSubscription>(module);
            repo.Add(tbSubscription);
            repo.SaveChanges();
            repo.Dispose();
            return tbSubscription.SubscriptionId; 
        }

        public void AddRange(IEnumerable<Subscription> module)
        {
            IBaseRepository<TbSubscription> repo = new BaseRepository<TbSubscription>(new AppDbContext());
            var tbSubscription = Mapping.Mapper.Map<IEnumerable<TbSubscription>>(module);
           repo.AddRange(tbSubscription);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void Delete(Subscription module)
        {
            IBaseRepository<TbSubscription> repo = new BaseRepository<TbSubscription>(new AppDbContext());
            var tbSubscription = Mapping.Mapper.Map<TbSubscription>(module);
           repo.Delete(tbSubscription);
            repo.SaveChanges();
            repo.Dispose();
           
        }

        public void DeleteById(int id)
        {
            IBaseRepository<TbSubscription> repo = new BaseRepository<TbSubscription>(new AppDbContext());
           repo.DeleteById(c => c.SubscriptionId == id);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void DeleteRange(IEnumerable<Subscription> modules)
        {
            IBaseRepository<TbSubscription> repo = new BaseRepository<TbSubscription>(new AppDbContext());
            var tbSubscription = Mapping.Mapper.Map<IEnumerable<TbSubscription>>(modules);
           repo.DeleteRange(tbSubscription);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public Subscription Find(Func<Subscription, bool> predicate)
        {
            IBaseRepository<TbSubscription> repo = new BaseRepository<TbSubscription>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbSubscription, bool>>(predicate);
            return Mapping.Mapper.Map<Subscription>(repo.Find(exp));
        }

        public IEnumerable<Subscription> FindAll(Func<Subscription, bool> predicate)
        {
            IBaseRepository<TbSubscription> repo = new BaseRepository<TbSubscription>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbSubscription, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Subscription>>(repo.FindAll(exp));
        }

        public IEnumerable<Subscription> GetAll()
        {
            IBaseRepository<TbSubscription> repo = new BaseRepository<TbSubscription>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<Subscription>>(repo.GetAll(
                    s=>s.Coach,
                    s=>s.Coach.Job,
                    s=>s.CreatedByReceptionist,
                    s => s.CreatedByReceptionist.Job,
                    s =>s.ExcerciseType,
                    s=>s.Member,
                    s=>s.Member.Person,
                    s =>s.Period,
                    s=>s.SubscriptionPeriod
                ));
        }

        public Subscription GetById(int id)
        {
            IBaseRepository<TbSubscription> repo = new BaseRepository<TbSubscription>(new AppDbContext());
            return Mapping.Mapper.Map<Subscription>(repo.GetById(
                    c=>c.SubscriptionId==id,
                    s => s.Coach,
                    s => s.Coach.Job,
                    s => s.CreatedByReceptionist,
                    s => s.CreatedByReceptionist.Job,
                    s => s.ExcerciseType,
                    s => s.Member,
                    s => s.Member.Person,
                    s => s.Period,
                    s => s.SubscriptionPeriod
                ));
        }

        public void Update(Subscription module)
        {
            IBaseRepository<TbSubscription> repo = new BaseRepository<TbSubscription>(new AppDbContext());
            var tbSubscription = Mapping.Mapper.Map<TbSubscription>(module);
           repo.Update(tbSubscription);
            repo.SaveChanges();
            repo.Dispose();
           
        }
    }
}
