using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class PayrollPaymentService : IBaseServices<PayrollPayment>
    {
        public UnitOfWorkBuissness _unitOfWork => throw new NotImplementedException();

        public void Add(PayrollPayment module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<PayrollPayment> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(PayrollPayment module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<PayrollPayment> modules)
        {
            throw new NotImplementedException();
        }

        public PayrollPayment Find(Func<PayrollPayment, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayrollPayment> FindAll(Func<PayrollPayment, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayrollPayment> GetAll()
        {
            throw new NotImplementedException();
        }

        public PayrollPayment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PayrollPayment module)
        {
            throw new NotImplementedException();
        }
    }
}
