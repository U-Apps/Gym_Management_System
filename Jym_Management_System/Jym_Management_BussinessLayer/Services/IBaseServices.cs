using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jym_Management_DataAccessLayer.Repositories;

namespace Jym_Management_BussinessLayer.Services
{
    public interface IBaseServices<T>:IBaseRepository<T>where T : class
    {

    }
}
