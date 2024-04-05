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
    public class PayrollPaymentService : IBaseServices<PayrollPayment>
    {


        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());

        public void Add(PayrollPayment module)
        {
            var tbPayrollPayment = Mapping.Mapper.Map<TbPayrollPayment>(module);
            _unit.PayrollPayments.Add(tbPayrollPayment);
            if (_unit.Complete() == 0)
                return;
        }

        public void AddRange(IEnumerable<PayrollPayment> module)
        {
            var tbPayrollPayment = Mapping.Mapper.Map<IEnumerable<TbPayrollPayment>>(module);
            _unit.PayrollPayments.AddRange(tbPayrollPayment);
            if (_unit.Complete() == 0)
                return;
        }

        public void Delete(PayrollPayment module)
        {
            var tbPayrollPayment = Mapping.Mapper.Map<TbPayrollPayment>(module);
            _unit.PayrollPayments.Delete(tbPayrollPayment);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteById(int id)
        {
            _unit.PayrollPayments.DeleteById(id);
            if (_unit.Complete() == 0)
                return;
        }

        public void DeleteRange(IEnumerable<PayrollPayment> modules)
        {
            var tbPayrollPayment = Mapping.Mapper.Map<IEnumerable<TbPayrollPayment>>(modules);
            _unit.PayrollPayments.DeleteRange(tbPayrollPayment);
            if (_unit.Complete() == 0)
                return;
        }

        public PayrollPayment Find(Func<PayrollPayment, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbPayrollPayment, bool>>(predicate);
            return Mapping.Mapper.Map<PayrollPayment>(_unit.PayrollPayments.Find(exp));
        }

        public IEnumerable<PayrollPayment> FindAll(Func<PayrollPayment, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbPayrollPayment, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<PayrollPayment>>(_unit.PayrollPayments.FindAll(exp));
        }

        public IEnumerable<PayrollPayment> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<PayrollPayment>>(_unit.PayrollPayments.GetAll());
        }

        public PayrollPayment GetById(int id)
        {
            return Mapping.Mapper.Map<PayrollPayment>(_unit.PayrollPayments.GetById(id));
        }

        public void Update(PayrollPayment module)
        {
            TbPayrollPayment tbPayrollPayment = Mapping.Mapper.Map<TbPayrollPayment>(module);
            _unit.PayrollPayments.Update(tbPayrollPayment);
            if (_unit.Complete() == 0)
                return;
        }
    }
}
