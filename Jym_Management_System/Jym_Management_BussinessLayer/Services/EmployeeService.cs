
using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class EmployeeService : IBaseServices<Employee>
    {
        

        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());

        public void Add(Employee module)
        {
            var tbEmployee = Mapping.Mapper.Map<TbEmployee>(module);
            _unit.Employees.Add(tbEmployee);
            int x = _unit.Complete();
        }

        public void AddRange(IEnumerable<Employee> module)
        {
            var tbEmployee = Mapping.Mapper.Map<IEnumerable<TbEmployee>>(module);
            _unit.Employees.AddRange(tbEmployee);
            int x = _unit.Complete();
        }

        public void Delete(Employee module)
        {
            var tbEmployee = Mapping.Mapper.Map<TbEmployee>(module);
            _unit.Employees.Delete(tbEmployee);
            int x = _unit.Complete();
        }
        public void DeleteById(int id)
        {
          _unit.Employees.DeleteById(id);
            int x=_unit.Complete();

        }

        public void DeleteRange(IEnumerable<Employee> modules)
        {
            var tbEmployee = Mapping.Mapper.Map<IEnumerable<TbEmployee>>(modules);
            _unit.Employees.DeleteRange(tbEmployee);
            
        }

        public Employee Find(Func<Employee, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbEmployee, bool>>(predicate);
            return Mapping.Mapper.Map<Employee>(_unit.Employees.Find(exp));
        }

        public IEnumerable<Employee> FindAll(Func<Employee, bool> predicate)
        {
           
            var exp = Mapping.Mapper.Map <Func<TbEmployee, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Employee>>(_unit.Employees.FindAll(exp));
        }

        public IEnumerable<Employee> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<Employee>>(_unit.Employees.GetAll());
        }   

        public Employee GetById(int id)
        {
            
           return Mapping.Mapper.Map<Employee>(_unit.Employees.GetById(id));
             
        }

        public void Update(Employee module)
        {
           
            TbEmployee x = Mapping.Mapper.Map<TbEmployee>(module);

            _unit.Employees.Update(x);
            _unit.Complete();
        }
    }
}
