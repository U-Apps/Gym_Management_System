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
        MemberResponse AddNewMember(CreateMemberDTO dto);
        IEnumerable<MemberResponse> GetAllMembers();
        MemberResponse? GetMemberById(int id);
        public bool updateMember(int id, UpdateMemberDTO memberInfo);
    }
}
