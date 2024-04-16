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
    public class SubscriptionPaymentServices : IBaseServices<SubscriptionPayment>
    {
       

        public void Add(SubscriptionPayment module)
        {
            IBaseRepository<TbSubscriptionPayment> repo = new BaseRepository<TbSubscriptionPayment>(new AppDbContext());
            var tbSubscriptionPayment = Mapping.Mapper.Map<TbSubscriptionPayment>(module);
             repo.Add(tbSubscriptionPayment);
            repo.SaveChanges(); 
            repo.Dispose();
        }

        public void AddRange(IEnumerable<SubscriptionPayment> module)
        {
            IBaseRepository<TbSubscriptionPayment> repo = new BaseRepository<TbSubscriptionPayment>(new AppDbContext());
            var tbSubscriptionPayment = Mapping.Mapper.Map<IEnumerable<TbSubscriptionPayment>>(module);
            repo.AddRange(tbSubscriptionPayment);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void Delete(SubscriptionPayment module)
        {
            IBaseRepository<TbSubscriptionPayment> repo = new BaseRepository<TbSubscriptionPayment>(new AppDbContext());
            var tbSubscriptionPayment = Mapping.Mapper.Map<TbSubscriptionPayment>(module);
            repo.Delete(tbSubscriptionPayment);
            repo.SaveChanges();
            repo.Dispose(); 
        }

        public void DeleteById(int id)
        {
            IBaseRepository<TbSubscriptionPayment> repo = new BaseRepository<TbSubscriptionPayment>(new AppDbContext());
           repo.DeleteById(c => c.PaymentId == id);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public void DeleteRange(IEnumerable<SubscriptionPayment> modules)
        {
            IBaseRepository<TbSubscriptionPayment> repo = new BaseRepository<TbSubscriptionPayment>(new AppDbContext());
            var tbSubscriptionPayment = Mapping.Mapper.Map<IEnumerable<TbSubscriptionPayment>>(modules);
            repo.DeleteRange(tbSubscriptionPayment);
            repo.SaveChanges();
            repo.Dispose();
            
        }

        public SubscriptionPayment Find(Func<SubscriptionPayment, bool> predicate)
        {
            IBaseRepository<TbSubscriptionPayment> repo = new BaseRepository<TbSubscriptionPayment>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbSubscriptionPayment, bool>>(predicate);
            return Mapping.Mapper.Map<SubscriptionPayment>(repo.Find(exp));
        }

        public IEnumerable<SubscriptionPayment> FindAll(Func<SubscriptionPayment, bool> predicate)
        {
            IBaseRepository<TbSubscriptionPayment> repo = new BaseRepository<TbSubscriptionPayment>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbSubscriptionPayment, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<SubscriptionPayment>>(repo.FindAll(exp));
        }

        public IEnumerable<SubscriptionPayment> GetAll()
        {
            IBaseRepository<TbSubscriptionPayment> repo = new BaseRepository<TbSubscriptionPayment>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<SubscriptionPayment>>(repo.GetAll(
                    sp=>sp.CreatedByUser,
                    sp=>sp.CreatedByUser.Person,
                    sp =>sp.Subscription,
                    sp => sp.Subscription.Coach,
                    sp => sp.Subscription.Coach.Job,
                    sp => sp.Subscription.CreatedByReceptionist,
                    sp => sp.Subscription.CreatedByReceptionist.Job,
                    sp => sp.Subscription.ExcerciseType,
                    sp => sp.Subscription.Member,
                    sp => sp.Subscription.Member.Person,
                    sp => sp.Subscription.Period,
                    sp => sp.Subscription.SubscriptionPeriod
                ));
        }

        public SubscriptionPayment GetById(int id)
        {
            IBaseRepository<TbSubscriptionPayment> repo = new BaseRepository<TbSubscriptionPayment>(new AppDbContext());
            return Mapping.Mapper.Map<SubscriptionPayment>(repo.GetById(
                    c => c.PaymentId == id,
                    sp => sp.CreatedByUser,
                    sp => sp.CreatedByUser.Person,
                    sp => sp.Subscription,
                    sp => sp.Subscription.Coach,
                    sp => sp.Subscription.Coach.Job,
                    sp => sp.Subscription.CreatedByReceptionist,
                    sp => sp.Subscription.CreatedByReceptionist.Job,
                    sp => sp.Subscription.ExcerciseType,
                    sp => sp.Subscription.Member,
                    sp => sp.Subscription.Member.Person,
                    sp => sp.Subscription.Period,
                    sp => sp.Subscription.SubscriptionPeriod
                    ));
        }

        public void Update(SubscriptionPayment module)
        {
            IBaseRepository<TbSubscriptionPayment> repo = new BaseRepository<TbSubscriptionPayment>(new AppDbContext());
            var tbSubscriptionPayment = Mapping.Mapper.Map<TbSubscriptionPayment>(module);
            repo.Update(tbSubscriptionPayment);
            repo.SaveChanges();
            repo.Dispose();
            
        }
    }
}
