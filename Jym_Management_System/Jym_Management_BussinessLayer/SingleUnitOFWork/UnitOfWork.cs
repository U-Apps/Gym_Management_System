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
        private static UnitOfWork _instance = null; 
        private static AppDbContext _appDbContext= null;
        private static readonly object _lock = new object();
        private UnitOfWorkBuissness() { }
       
        public static UnitOfWork getInstenece()
        {
            if(_instance == null) 
            { 
                lock(_lock)
                {
                    if (_instance == null)
                    {
                        _appDbContext = new AppDbContext();
                        _instance = new UnitOfWork(_appDbContext);
                        return _instance;
                    }
                        
                }
            }
            return _instance;
            

        }

    }
}
