using GymManagement.BussinessCore.Contracts.Repositories;
using GymManagement.BussinessCore.Contracts.Services;
using GymManagement.BussinessCore.Models;
using System.Linq.Expressions;

namespace GymManagement.BusinessCore.Services
{
    public class PayrollPaymentService : IBaseServices<PayrollPayment>
    {
        protected readonly IBaseRepository<PayrollPayment> _Repository;
        public PayrollPaymentService(IBaseRepository<PayrollPayment> repository)
        {
            _Repository = repository;
        }
        public int Add(PayrollPayment model)
        {
            model.PaymentDate = DateTime.Now;
            _Repository.Add(model);
            return model.PaymentId;
        }

        public void AddRange(IEnumerable<PayrollPayment> model)
        {
            _Repository.AddRange(model);
        }

        public void Delete(PayrollPayment model)
        {
            _Repository.Delete(model);
        }

        public void DeleteById(int id)
        {
            _Repository.DeleteById(c => c.PaymentId == id);
        }

        public void DeleteRange(IEnumerable<PayrollPayment> model)
        {
            _Repository.DeleteRange(model);
        }

        public PayrollPayment Find(Expression<Func<PayrollPayment, bool>> predicate)
        {
            return _Repository.Find(predicate);
        }

        public IEnumerable<PayrollPayment> FindAll(Func<PayrollPayment, bool> predicate)
        {
            return _Repository.FindAll(predicate);
        }

        public IEnumerable<PayrollPayment> GetAll()
        {
            return _Repository.GetAll(prP=>prP.Employee,p=>p.Employee.Person);
        }

        public PayrollPayment GetById(int id)
        {
            return _Repository.GetById(c => c.PaymentId == id, prP => prP.Employee,person=>person.Employee.Person);
        }

        public void Update(PayrollPayment model)
        {
            model.PaymentDate=DateTime.Now;
            _Repository.Update(model);
        }
    }
}
