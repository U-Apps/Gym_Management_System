using GymManagement.BusinessCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.BusinessCore.Contracts.Services
{
    public interface ISubscriptionService
    {
        bool AddNewSubscription(Subscription model);
    }
}
