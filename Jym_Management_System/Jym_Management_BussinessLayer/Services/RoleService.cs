using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class RoleService : IBaseServices<Role>
    {
        public UnitOfWorkBuissness _unitOfWork => throw new NotImplementedException();

        public void Add(Role module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Role> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(Role module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<Role> modules)
        {
            throw new NotImplementedException();
        }

        public Role Find(Func<Role, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> FindAll(Func<Role, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public Role GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Role module)
        {
            throw new NotImplementedException();
        }
    }
}
