using GymManagement.BusinessCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.BusinessCore.Contracts.Repositories
{
    public interface IMemberRepo
    {
        void AddNewMember(Member member);
        IEnumerable<Member> GetMembers();
    }
}
