using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class PermssionService : IBaseServices<Permssion>
    {
        public UnitOfWorkBuissness _unitOfWork => throw new NotImplementedException();

        public void Add(Permssion module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Permssion> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(Permssion module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<Permssion> modules)
        {
            throw new NotImplementedException();
        }

        public Permssion Find(Func<Permssion, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Permssion> FindAll(Func<Permssion, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Permssion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Permssion GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Permssion module)
        {
            throw new NotImplementedException();
        }
    }
}
