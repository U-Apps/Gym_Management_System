using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        //private readonly AppDbContext _context;

        //public BaseRepository<TbMember> Members { get; private set; }
        //public BaseRepository<TbUser> Users { get; private set; }
        //public BaseRepository<TbEmployee> Employees { get; private set; }
        //public BaseRepository<TbExerciseType> ExerciseTypes { get; private set; }
        //public BaseRepository<TbJob> Jobs { get; private set; }
        //public BaseRepository<TbPayrollPayment> PayrollPayments { get; private set; }
        //public BaseRepository<TbJobHistory> JobHistories { get; private set; }
        //public BaseRepository<TbPeriod> Periods { get; private set; }
        //public BaseRepository<TbPermssion> Permssions { get; private set; }
        //public BaseRepository<TbPerson> Persons { get; private set; }
        //public BaseRepository<TbRole> Roles { get; private set; }
        //public BaseRepository<TbSubsciptionPeriod> SubsciptionPeriods { get; private set; }
        //public BaseRepository<TbSubscription> Subscriptions { get; private set; }
        //public BaseRepository<TbSubscriptionPayment> SubscriptionPayments { get; private set; }


        //public UnitOfWork(AppDbContext context)
        //{
        //    _context = context;
        //    Members = new BaseRepository<TbMember>(_context);
        //    Users = new BaseRepository<TbUser>(_context);
        //    Employees = new BaseRepository<TbEmployee>(_context);
        //    ExerciseTypes = new BaseRepository<TbExerciseType>(_context);
        //    Jobs = new BaseRepository<TbJob>(_context);
        //    PayrollPayments = new BaseRepository<TbPayrollPayment>(_context);
        //    JobHistories = new BaseRepository<TbJobHistory>(_context);
        //    Periods = new BaseRepository<TbPeriod>(_context);
        //    Permssions = new BaseRepository<TbPermssion>(_context);
        //    Persons = new BaseRepository<TbPerson>(_context);
        //    Roles = new BaseRepository<TbRole>(_context);
        //    SubsciptionPeriods = new BaseRepository<TbSubsciptionPeriod>(_context);
        //    Subscriptions = new BaseRepository<TbSubscription>(_context);
        //    SubscriptionPayments = new BaseRepository<TbSubscriptionPayment>(_context);
        //}

        ////this method saves changes in database
        //public int Complete()
        //{

        //    return _context.SaveChanges();
        //}

        //public void Dispose()
        //{
        //    _context.Dispose();
        //}

    }
}
