using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_DataAccessLayer.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
       // public IBaseRepository<Member> Members { get }

        int Complete();

        
    }
}
