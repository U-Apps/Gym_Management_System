using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services 
{
    public class JobHistoryService : IBaseServices<JobHistory>
    {
        public UnitOfWorkBuissness _unitOfWork => throw new NotImplementedException();

        public void Add(JobHistory module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<JobHistory> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(JobHistory module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<JobHistory> modules)
        {
            throw new NotImplementedException();
        }

        public JobHistory Find(Func<JobHistory, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JobHistory> FindAll(Func<JobHistory, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JobHistory> GetAll()
        {
            throw new NotImplementedException();
        }

        public JobHistory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(JobHistory module)
        {
            throw new NotImplementedException();
        }
    }
}
