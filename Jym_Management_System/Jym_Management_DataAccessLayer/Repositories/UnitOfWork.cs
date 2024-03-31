using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IBaseRepository<TbMember> Members { get; private set; }
        public IBaseRepository<TbUser> Users { get;  set; }
        public IBaseRepository<TbEmployee> Employees { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Members = new BaseRepository<TbMember>(_context);
            Users = new BaseRepository<TbUser>(_context);
            Employees = new BaseRepository<TbEmployee>(_context);

        }

        //this method saves changes in database
        public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
