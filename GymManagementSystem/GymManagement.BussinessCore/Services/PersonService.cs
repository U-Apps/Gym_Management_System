﻿using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Jym_Management_BussinessLayer.Services
{
    public class PersonService :IBaseServices<Person>
    {
        

        public int Add(Person module)
        {
            BaseRepository<TbPerson> repo = new(new AppDbContext());
            var tbPerson = Mapping.Mapper.Map<TbPerson>(module);
            repo.Add(tbPerson);
            repo.SaveChanges();
            repo.Dispose();
            return tbPerson.PersonId;
        }

        public void AddRange(IEnumerable<Person> module)
        {
            BaseRepository<TbPerson> repo = new(new AppDbContext());
            var tbPerson = Mapping.Mapper.Map<IEnumerable<TbPerson>>(module);
            repo.AddRange(tbPerson);
            repo.SaveChanges();
            repo.Dispose();

        }

        public void Delete(Person module)
        {
            BaseRepository<TbPerson> repo = new(new AppDbContext());
            var tbPerson = Mapping.Mapper.Map<TbPerson>(module);
           repo.Delete(tbPerson);
            repo.SaveChanges();
            repo.Dispose();

        }

        public void DeleteById(int id)
        {
            BaseRepository<TbPerson> repo = new(new AppDbContext());
           repo.DeleteById(c => c.PersonId == id);
            repo.SaveChanges();
            repo.Dispose();

        }

        public void DeleteRange(IEnumerable<Person> modules)
        {
            BaseRepository<TbPerson> repo = new(new AppDbContext());
            var tbPerson = Mapping.Mapper.Map<IEnumerable<TbPerson>>(modules);
            repo.DeleteRange(tbPerson);
            repo.SaveChanges();
            repo.Dispose();
        }

        public Person Find(Expression<Func<Person, bool>>  predicate)
        {
            BaseRepository<TbPerson> repo = new(new AppDbContext());
            var exp = Mapping.Mapper.Map< Expression<Func<TbPerson, bool>>>(predicate);
            return Mapping.Mapper.Map<Person>(repo.Find(exp));
            
        }

        public IEnumerable<Person> FindAll(Func<Person, bool> predicate)
        {
            BaseRepository<TbPerson> repo = new(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbPerson, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Person>>(repo.FindAll(exp));
           

        }

        public IEnumerable<Person> GetAll()
        {
            BaseRepository<TbPerson> repo = new(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<Person>>(repo.GetAll(c=>c.Member,c=>c.Employee,c=>c.User!));
        }

        public Person GetById(int id)
        {
            BaseRepository<TbPerson> repo = new(new AppDbContext());
            return Mapping.Mapper.Map<Person>(repo.GetById(c => c.PersonId == id));
        }

        public void Update(Person module)
        {
            BaseRepository<TbPerson> repo = new(new AppDbContext());
            TbPerson tbPerson = Mapping.Mapper.Map<TbPerson>(module);
            repo.Update(tbPerson);
            repo.SaveChanges();
            repo.Dispose();

        }
        
    }
}
