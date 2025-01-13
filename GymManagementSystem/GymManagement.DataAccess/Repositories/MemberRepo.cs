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
    class MemberRepo : BaseRepository<Member, int>, IMemberRepo
    {
        public MemberRepo(AppDbContext context) : base(context)
        {
        }

        public bool AreEmailAndPhoneNumberUniqueAsync(string email, string phoneNumber)
        {
            return !_context.Set<Member>().Any(m => m.Email == email || m.PhoneNumber == phoneNumber);
        }

        public bool IsEmailUniqueAsync(string email)
        {
            return !_context.Set<Member>().Any(m => m.Email == email);
        }

        public bool IsPhoneNumberUniqueAsync(string phoneNumber)
        {
            return !_context.Set<Member>().Any(m => m.PhoneNumber == phoneNumber);
        }
    }
}
