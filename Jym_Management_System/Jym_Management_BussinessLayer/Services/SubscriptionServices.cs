using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class SubscriptionServices : IBaseServices<Subscription>
    {
        public UnitOfWorkBuissness _unitOfWork => throw new NotImplementedException();

        public void Add(Subscription module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Subscription> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(Subscription module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<Subscription> modules)
        {
            throw new NotImplementedException();
        }

        public Subscription Find(Func<Subscription, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subscription> FindAll(Func<Subscription, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subscription> GetAll()
        {
            throw new NotImplementedException();
        }

        public Subscription GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Subscription module)
        {
            throw new NotImplementedException();
        }
    }
}
