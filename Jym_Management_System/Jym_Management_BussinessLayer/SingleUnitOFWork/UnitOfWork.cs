using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jym_Management_DataAccessLayer.Repositories;
using Jym_Management_DataAccessLayer.Data;
namespace Jym_Management_BussinessLayer.SingleUnitOFWork
{
    public sealed class UnitOfWorkBuissness
    {
        public readonly UnitOfWork UnitOfWork = null;
        private static UnitOfWorkBuissness _instance = null;
        private static AppDbContext _appDbContext= null;
        private static readonly object _lock = new object();
        private UnitOfWorkBuissness()
        {
            _appDbContext = new AppDbContext();
            UnitOfWork = new UnitOfWork(_appDbContext);
        }
        
       
        public static UnitOfWorkBuissness getInstenece()
        {
            if(_instance == null) 
            { 
                lock(_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UnitOfWorkBuissness();
                        return _instance;
                    }
                        
                }
            }
            return _instance;
            

        }

    }
}
