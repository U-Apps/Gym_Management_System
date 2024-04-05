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
    public class SubscriptionPaymentServices : IBaseServices<SubscriptionPayment>
    {
        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());

        public void Add(SubscriptionPayment module)
        {
            var tbSubscriptionPayment = Mapping.Mapper.Map<TbSubscriptionPayment>(module);
            _unit.SubscriptionPayments.Add(tbSubscriptionPayment);
            if (_unit.Complete() == 0)
                return;
        }

        public void AddRange(IEnumerable<SubscriptionPayment> module)
        {
            var tbSubscriptionPayment = Mapping.Mapper.Map<IEnumerable<TbSubscriptionPayment>>(module);
            _unit.SubscriptionPayments.AddRange(tbSubscriptionPayment);
            if (_unit.Complete() == 0)
                return;
        }

        public void Delete(SubscriptionPayment module)
        {
            var tbSubscriptionPayment = Mapping.Mapper.Map<TbSubscriptionPayment>(module);
            _unit.SubscriptionPayments.Delete(tbSubscriptionPayment);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteById(int id)
        {
            _unit.SubscriptionPayments.DeleteById(id);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteRange(IEnumerable<SubscriptionPayment> modules)
        {
            var tbSubscriptionPayment = Mapping.Mapper.Map<IEnumerable<TbSubscriptionPayment>>(modules);
            _unit.SubscriptionPayments.DeleteRange(tbSubscriptionPayment);
            if (_unit.Complete() == 0)
                return;
        }

        public SubscriptionPayment Find(Func<SubscriptionPayment, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbSubscriptionPayment, bool>>(predicate);
            return Mapping.Mapper.Map<SubscriptionPayment>(_unit.SubscriptionPayments.Find(exp));
        }

        public IEnumerable<SubscriptionPayment> FindAll(Func<SubscriptionPayment, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbSubscriptionPayment, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<SubscriptionPayment>>(_unit.SubscriptionPayments.FindAll(exp));
        }

        public IEnumerable<SubscriptionPayment> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<SubscriptionPayment>>(_unit.SubscriptionPayments.GetAll());
        }

        public SubscriptionPayment GetById(int id)
        {
            return Mapping.Mapper.Map<SubscriptionPayment>(_unit.SubscriptionPayments.GetById(id));
        }

        public void Update(SubscriptionPayment module)
        {
            var tbSubscriptionPayment = Mapping.Mapper.Map<TbSubscriptionPayment>(module);
            _unit.SubscriptionPayments.Update(tbSubscriptionPayment);
            if (_unit.Complete() == 0)
                return;
        }
    }
}
