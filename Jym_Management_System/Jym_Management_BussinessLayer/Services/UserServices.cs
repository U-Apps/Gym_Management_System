using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class UserServices : IBaseServices<User>
    {
        public UnitOfWorkBuissness _unitOfWork => throw new NotImplementedException();

        public void Add(User module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<User> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(User module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<User> modules)
        {
            throw new NotImplementedException();
        }

        public User Find(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> FindAll(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User module)
        {
            throw new NotImplementedException();
        }
    }
}
