using GymManagement.BussinessCore.Contracts.Repositories;
using GymManagement.BussinessCore.Contracts.Services;
using GymManagement.BussinessCore.Models;
using System.Linq.Expressions;

namespace GymManagement.BusinessCore.Services
{
    public class EmployeeService : IBaseServices<Employee>
    {
        protected readonly IBaseRepository<Employee> _Repository;
        public EmployeeService(IBaseRepository<Employee> repository)
        {
            _Repository = repository;
        }


        public int Add(Employee model)
        {

            _Repository.Add(model);
            return model.EmployeeId;
        }
        
        public void AddRange(IEnumerable<Employee> model)
        {
            _Repository.AddRange(model);
        }

        public void Delete(Employee module)
        {
            _Repository.Delete(module);
        }
        public void DeleteById(int id)
        {
            _Repository.DeleteById(c=>c.EmployeeId==id);
        }

        public void DeleteRange(IEnumerable<Employee> model)
        {
            _Repository.DeleteRange(model);
        }

        public Employee Find(Expression<Func<Employee, bool>> predicate)
        {
            return _Repository.Find(predicate);
        }

        public IEnumerable<Employee> FindAll(Func<Employee, bool> predicate)
        {
            return _Repository.FindAll(predicate);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _Repository.GetAll(d => d.Person,d=>d.PayrollPayments ,d=>d.CurrentJob);
        }   

        public Employee GetById(int id)
        {
            return _Repository.GetById(c=>c.EmployeeId==id,c=>c.Person,c=>c.PayrollPayments,c=>c.CurrentJob);
       
        }

        public void Update(Employee model)
        {
            _Repository.Update(model);
        }
    }
}
