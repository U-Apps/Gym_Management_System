
using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;


namespace Jym_Management_BussinessLayer.Services
{
    public class EmployeeService : IBaseServices<Employee>
    {


        public void Add(Employee module)
        {
            BaseRepository<TbEmployee> repo = new(new AppDbContext());

            var tbEmployee = Mapping.Mapper.Map<TbEmployee>(module);
            repo.Add(tbEmployee);
            repo.SaveChanges();
            repo.Dispose();
              

        }
        
        public void AddRange(IEnumerable<Employee> module)
        {
            BaseRepository<TbEmployee> repo = new(new AppDbContext());
            var tbEmployee = Mapping.Mapper.Map<IEnumerable<TbEmployee>>(module);
            repo.AddRange(tbEmployee);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void Delete(Employee module)
        {
            BaseRepository<TbEmployee> repo = new(new AppDbContext());
            var tbEmployee = Mapping.Mapper.Map<TbEmployee>(module);
            repo.Delete(tbEmployee);
             repo.SaveChanges();
             repo.Dispose();   
        }
        public void DeleteById(int id)
        {
            BaseRepository<TbEmployee> repo = new(new AppDbContext());
            repo.DeleteById(c=>c.EmployeeId==id);
             repo.SaveChanges();
             repo.Dispose();

        }

        public void DeleteRange(IEnumerable<Employee> modules)
        {
            BaseRepository<TbEmployee> repo = new(new AppDbContext());
            var tbEmployee = Mapping.Mapper.Map<IEnumerable<TbEmployee>>(modules);
            repo.DeleteRange(tbEmployee);
             repo.SaveChanges();
             repo.Dispose();
            
        }

        public Employee Find(Func<Employee, bool> predicate)
        {
            BaseRepository<TbEmployee> repo = new(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbEmployee, bool>>(predicate);
            return Mapping.Mapper.Map<Employee>(repo.Find(exp));
        }

        public IEnumerable<Employee> FindAll(Func<Employee, bool> predicate)
        {
            BaseRepository<TbEmployee> repo = new(new AppDbContext());

            var exp = Mapping.Mapper.Map <Func<TbEmployee, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Employee>>(repo.FindAll(exp));
        }

        public IEnumerable<Employee> GetAll()
        {

            IBaseRepository<TbEmployee> repo = new BaseRepository<TbEmployee>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<Employee>>(repo.GetAll(d => d.Person,d=>d.TbPayrollPayments));
            
                
        }   

        public Employee GetById(int id)
        {

            BaseRepository<TbEmployee> repo = new(new AppDbContext());

            return Mapping.Mapper.Map<Employee>(repo.GetById(c=>c.EmployeeId==id,c=>c.Person,c=>c.TbPayrollPayments));
       
        }

        public void Update(Employee module)
        {
            BaseRepository<TbEmployee> repo = new(new AppDbContext());

            TbEmployee x = Mapping.Mapper.Map<TbEmployee>(module);

            repo.Update(x);
             repo.SaveChanges();
             repo.Dispose();   






        }
    }
}
