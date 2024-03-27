using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_DataAccessLayer.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

    }
}
