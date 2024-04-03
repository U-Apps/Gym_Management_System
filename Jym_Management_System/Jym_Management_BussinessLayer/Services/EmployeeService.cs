
using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using Jym_Management_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class EmployeeService : IBaseServices<Employee>
    {
        public UnitOfWorkBuissness _unitOfWork => UnitOfWorkBuissness.getInstenece();

        public void Add(Employee module)
        {
            var tbEmployee = Mapping.Mapper.Map<TbEmployee>(module);
            _unitOfWork.UnitOfWork.Employees.Add(tbEmployee);
        }

        public void AddRange(IEnumerable<Employee> module)
        {
            var tbEmployee = Mapping.Mapper.Map<IEnumerable<TbEmployee>>(module);
            _unitOfWork.UnitOfWork.Employees.AddRange(tbEmployee);
        }

        public void Delete(Employee module)
        {
            var tbEmployee = Mapping.Mapper.Map<TbEmployee>(module);
            _unitOfWork.UnitOfWork.Employees.Delete(tbEmployee);
        }

        public void DeleteById(int id)
        {
           _unitOfWork.UnitOfWork.Employees.DeleteById(id);

        }

        public void DeleteRange(IEnumerable<Employee> modules)
        {
            var tbEmployee = Mapping.Mapper.Map<IEnumerable<TbEmployee>>(modules);
            _unitOfWork.UnitOfWork.Employees.DeleteRange(tbEmployee);
            
        }

        public Employee Find(Func<Employee, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbEmployee, bool>>(predicate);
            return Mapping.Mapper.Map<Employee>(_unitOfWork.UnitOfWork.Employees.Find(exp));
        }

        public IEnumerable<Employee> FindAll(Func<Employee, bool> predicate)
        {
           
            var exp = Mapping.Mapper.Map <Func<TbEmployee, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<Employee>>(_unitOfWork.UnitOfWork.Employees.FindAll(exp));
        }

        public IEnumerable<Employee> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<Employee>>(_unitOfWork.UnitOfWork.Employees.GetAll());
        }   

        public Employee GetById(int id)
        {
            
           return Mapping.Mapper.Map<Employee>(_unitOfWork.UnitOfWork.Employees.GetById(id));
             
        }

        public void Update(Employee module)
        {
            _unitOfWork.UnitOfWork.Employees.Update(Mapping.Mapper.Map<TbEmployee>(module));
        }
    }
}
