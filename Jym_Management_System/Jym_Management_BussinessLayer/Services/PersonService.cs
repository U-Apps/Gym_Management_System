using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class PersonService : IBaseServices<Person>
    {
        public UnitOfWorkBuissness _unitOfWork => throw new NotImplementedException();

        public void Add(Person module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Person> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<Person> modules)
        {
            throw new NotImplementedException();
        }

        public Person Find(Func<Person, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> FindAll(Func<Person, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Person module)
        {
            throw new NotImplementedException();
        }
    }
}
