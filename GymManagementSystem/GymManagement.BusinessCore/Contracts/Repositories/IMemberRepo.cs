using GymManagement.BusinessCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.BusinessCore.Contracts.Repositories
{
    public interface IMemberRepo : IBaseRepository<Member, int>
    {
        bool IsEmailUniqueAsync(string email);
        bool IsPhoneNumberUniqueAsync(string phoneNumber);
        bool AreEmailAndPhoneNumberUniqueAsync(string email, string phoneNumber);
    }
}
