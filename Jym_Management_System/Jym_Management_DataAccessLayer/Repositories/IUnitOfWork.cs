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

        public int Complete();

        
    }
}
