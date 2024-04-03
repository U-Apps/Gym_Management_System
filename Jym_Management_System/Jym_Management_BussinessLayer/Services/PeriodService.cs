using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class PeriodService : IBaseServices<Period>
    {
        public UnitOfWorkBuissness _unitOfWork => throw new NotImplementedException();

        public void Add(Period module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Period> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(Period module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<Period> modules)
        {
            throw new NotImplementedException();
        }

        public Period Find(Func<Period, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Period> FindAll(Func<Period, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Period> GetAll()
        {
            throw new NotImplementedException();
        }

        public Period GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Period module)
        {
            throw new NotImplementedException();
        }
    }
}
