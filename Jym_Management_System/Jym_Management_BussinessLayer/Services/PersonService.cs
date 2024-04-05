using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class PersonService : IBaseServices<Person>
    {
        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());

        public void Add(Person module)
        {
            var tbPerson = Mapping.Mapper.Map<TbPerson>(module);
            _unit.Persons.Add(tbPerson);
            if (_unit.Complete() == 0)
                return;
        }

        public void AddRange(IEnumerable<Person> module)
        {
            var tbPerson = Mapping.Mapper.Map<IEnumerable<TbPerson>>(module);
            _unit.Persons.AddRange(tbPerson);
            if (_unit.Complete() == 0)
                return;
        }

        public void Delete(Person module)
        {
            var tbPerson = Mapping.Mapper.Map<TbPerson>(module);
            _unit.Persons.Delete(tbPerson);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteById(int id)
        {
            _unit.Persons.DeleteById(id);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteRange(IEnumerable<Person> modules)
        {
            var tbPerson = Mapping.Mapper.Map<IEnumerable<TbPerson>>(modules);
            _unit.Persons.DeleteRange(tbPerson);
            if (_unit.Complete() == 0)
                return;
        }

        public Person Find(Func<Person, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbPerson, bool>>(predicate);
            return Mapping.Mapper.Map<Person>(_unit.Persons.Find(exp));
        }

        public IEnumerable<Person> FindAll(Func<Person, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbPerson, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Person>>(_unit.Persons.FindAll(exp));
        }

        public IEnumerable<Person> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<Person>>(_unit.Persons.GetAll());
        }

        public Person GetById(int id)
        {
            return Mapping.Mapper.Map<Person>(_unit.Persons.GetById(id));
        }

        public void Update(Person module)
        {
            TbPerson tbPerson = Mapping.Mapper.Map<TbPerson>(module);
            _unit.Persons.Update(tbPerson);
            if (_unit.Complete() == 0)
                return;
        }
    }
}
