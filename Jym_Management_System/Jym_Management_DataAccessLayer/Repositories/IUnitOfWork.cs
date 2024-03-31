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
         public IBaseRepository<TbMember> Members { get;  set; }
        public IBaseRepository<TbUser> Users { get;  set; }
        public IBaseRepository<TbEmployee> Employees { get;  set; }

        int Complete();

        
    }
}
