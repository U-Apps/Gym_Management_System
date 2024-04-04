using Jym_Management_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_DataAccessLayer.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        public IBaseRepository<TbMember> Members { get;}
        public IBaseRepository<TbUser> Users { get;}
        public IBaseRepository<TbEmployee> Employees { get;}
        public IBaseRepository<TbExerciseType> ExerciseTypes { get; }
        public IBaseRepository<TbJob> Jobs { get; }
        public IBaseRepository<TbPayrollPayment> PayrollPayments { get; }
        public IBaseRepository<TbJobHistory> JobHistories { get; }
        public IBaseRepository<TbPeriod> Periods { get; }
        public IBaseRepository<TbPermssion> Permssions { get; }
        public IBaseRepository<TbPerson> Persons { get; }
        public IBaseRepository<TbRole> Roles { get; }
        public IBaseRepository<TbSubsciptionPeriod> SubsciptionPeriods { get; }
        public IBaseRepository<TbSubscription> Subscriptions { get; }
        public IBaseRepository<TbSubscriptionPayment> SubscriptionPayments { get; }

        public int Complete();

        
    }
}
