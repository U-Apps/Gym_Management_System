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


        

        public void Add(PayrollPayment module)
        {
            IBaseRepository<TbPayrollPayment> repo = new BaseRepository<TbPayrollPayment>(new AppDbContext());
            var tbPayrollPayment = Mapping.Mapper.Map<TbPayrollPayment>(module);
           repo.Add(tbPayrollPayment);
           repo.SaveChanges();
            repo.Dispose();
        }

        public void AddRange(IEnumerable<PayrollPayment> module)
        {
            IBaseRepository<TbPayrollPayment> repo = new BaseRepository<TbPayrollPayment>(new AppDbContext());
            var tbPayrollPayment = Mapping.Mapper.Map<IEnumerable<TbPayrollPayment>>(module);
            repo.AddRange(tbPayrollPayment);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void Delete(PayrollPayment module)
        {
            IBaseRepository<TbPayrollPayment> repo = new BaseRepository<TbPayrollPayment>(new AppDbContext());
            var tbPayrollPayment = Mapping.Mapper.Map<TbPayrollPayment>(module);
            repo.Delete(tbPayrollPayment);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void DeleteById(int id)
        {
            IBaseRepository<TbPayrollPayment> repo = new BaseRepository<TbPayrollPayment>(new AppDbContext());
            repo.DeleteById(c => c.PaymentId == id);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void DeleteRange(IEnumerable<PayrollPayment> modules)
        {
            IBaseRepository<TbPayrollPayment> repo = new BaseRepository<TbPayrollPayment>(new AppDbContext());
            var tbPayrollPayment = Mapping.Mapper.Map<IEnumerable<TbPayrollPayment>>(modules);
            repo.DeleteRange(tbPayrollPayment);
            repo.SaveChanges();
            repo.Dispose();
        }

        public PayrollPayment Find(Func<PayrollPayment, bool> predicate)
        {
            IBaseRepository<TbPayrollPayment> repo = new BaseRepository<TbPayrollPayment>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbPayrollPayment, bool>>(predicate);
            return Mapping.Mapper.Map<PayrollPayment>(repo.Find(exp));
        }

        public IEnumerable<PayrollPayment> FindAll(Func<PayrollPayment, bool> predicate)
        {
            IBaseRepository<TbPayrollPayment> repo = new BaseRepository<TbPayrollPayment>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbPayrollPayment, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<PayrollPayment>>(repo.FindAll(exp));
        }

        public IEnumerable<PayrollPayment> GetAll()
        {
            IBaseRepository<TbPayrollPayment> repo = new BaseRepository<TbPayrollPayment>(new AppDbContext());

            return Mapping.Mapper.Map<IEnumerable<PayrollPayment>>(repo.GetAll());
        }

        public PayrollPayment GetById(int id)
        {
            IBaseRepository<TbPayrollPayment> repo = new BaseRepository<TbPayrollPayment>(new AppDbContext());

            return Mapping.Mapper.Map<PayrollPayment>(repo.GetById(c => c.PaymentId == id));
        }

        public void Update(PayrollPayment module)
        {
            IBaseRepository<TbPayrollPayment> repo = new BaseRepository<TbPayrollPayment>(new AppDbContext());

            TbPayrollPayment tbPayrollPayment = Mapping.Mapper.Map<TbPayrollPayment>(module);
           repo.Update(tbPayrollPayment);
            repo.SaveChanges();
            repo.Dispose();
        }
    }
}
