using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Models;
using GymManagement.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DataAccess.Repositories
{
    class MemberRepo(AppDbContext _appDbContext) : IMemberRepo
    {
        public void AddNewMember(Member member)
        {
            _appDbContext.Set<Member>().Add(member);
            _appDbContext.SaveChanges();
        }

        public Member GetMemberById(int id)
        {
            return _appDbContext.Set<Member>().AsNoTracking().FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Member> GetMembers()
        {
            return _appDbContext.Set<Member>().AsNoTracking().ToList();
        }                    
    }
}
