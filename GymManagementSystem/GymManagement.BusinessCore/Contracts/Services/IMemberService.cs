using GymManagement.BusinessCore.DTOs;
using GymManagement.BusinessCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.BusinessCore.Contracts.Services
{
    public interface IMemberService
    {
        bool AddNewMember(Member member, Subscription subscriptionInfo);
        IEnumerable<MemberResponse> GetAllMembers();
        MemberResponse GetMemberById(int id);
    }
}
