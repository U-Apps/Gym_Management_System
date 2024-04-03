using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class JobService : IBaseServices<Job>
    {
        public UnitOfWorkBuissness _unitOfWork => throw new NotImplementedException();

        public void Add(Job module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Job> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(Job module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<Job> modules)
        {
            throw new NotImplementedException();
        }

        public Job Find(Func<Job, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Job> FindAll(Func<Job, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Job> GetAll()
        {
            throw new NotImplementedException();
        }

        public Job GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Job module)
        {
            throw new NotImplementedException();
        }
    }

}
