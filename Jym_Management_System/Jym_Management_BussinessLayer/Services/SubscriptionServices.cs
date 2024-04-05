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
    public class SubscriptionServices : IBaseServices<Subscription>
    {
        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());

        public void Add(Subscription module)
        {
            var tbSubscription = Mapping.Mapper.Map<TbSubscription>(module);
            _unit.Subscriptions.Add(tbSubscription);
            if (_unit.Complete() == 0)
                return;
        }

        public void AddRange(IEnumerable<Subscription> module)
        {
            var tbSubscription = Mapping.Mapper.Map<IEnumerable<TbSubscription>>(module);
            _unit.Subscriptions.AddRange(tbSubscription);
            if (_unit.Complete() == 0)
                return;
        }

        public void Delete(Subscription module)
        {
            var tbSubscription = Mapping.Mapper.Map<TbSubscription>(module);
            _unit.Subscriptions.Delete(tbSubscription);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteById(int id)
        {
            _unit.Subscriptions.DeleteById(id);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteRange(IEnumerable<Subscription> modules)
        {
            var tbSubscription = Mapping.Mapper.Map<IEnumerable<TbSubscription>>(modules);
            _unit.Subscriptions.DeleteRange(tbSubscription);
            if (_unit.Complete() == 0)
                return;
        }

        public Subscription Find(Func<Subscription, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbSubscription, bool>>(predicate);
            return Mapping.Mapper.Map<Subscription>(_unit.Subscriptions.Find(exp));
        }

        public IEnumerable<Subscription> FindAll(Func<Subscription, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbSubscription, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Subscription>>(_unit.Subscriptions.FindAll(exp));
        }

        public IEnumerable<Subscription> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<Subscription>>(_unit.Subscriptions.GetAll());
        }

        public Subscription GetById(int id)
        {
            return Mapping.Mapper.Map<Subscription>(_unit.Subscriptions.GetById(id));
        }

        public void Update(Subscription module)
        {
            var tbSubscription = Mapping.Mapper.Map<TbSubscription>(module);
            _unit.Subscriptions.Update(tbSubscription);
            if (_unit.Complete() == 0)
                return;
        }
    }
}
