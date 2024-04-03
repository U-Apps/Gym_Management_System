using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class SubscriptionPaymentServices : IBaseServices<SubscriptionPayment>
    {
        public UnitOfWorkBuissness _unitOfWork => throw new NotImplementedException();

        public void Add(SubscriptionPayment module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<SubscriptionPayment> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubscriptionPayment module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<SubscriptionPayment> modules)
        {
            throw new NotImplementedException();
        }

        public SubscriptionPayment Find(Func<SubscriptionPayment, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubscriptionPayment> FindAll(Func<SubscriptionPayment, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubscriptionPayment> GetAll()
        {
            throw new NotImplementedException();
        }

        public SubscriptionPayment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(SubscriptionPayment module)
        {
            throw new NotImplementedException();
        }
    }
}
