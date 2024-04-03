using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class SubsciptionPeriodServices : IBaseServices<SubsciptionPeriod>
    {
        public UnitOfWorkBuissness _unitOfWork => throw new NotImplementedException();

        public void Add(SubsciptionPeriod module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<SubsciptionPeriod> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubsciptionPeriod module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<SubsciptionPeriod> modules)
        {
            throw new NotImplementedException();
        }

        public SubsciptionPeriod Find(Func<SubsciptionPeriod, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubsciptionPeriod> FindAll(Func<SubsciptionPeriod, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubsciptionPeriod> GetAll()
        {
            throw new NotImplementedException();
        }

        public SubsciptionPeriod GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(SubsciptionPeriod module)
        {
            throw new NotImplementedException();
        }
    }
}
