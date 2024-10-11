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
    class SubscriptionPeriodRepo(AppDbContext _appDbContext) : ISubscriptionPeriodRepo
    {
        public SubscriptionPeriod GetPeriodById(int periodId)
        {
            return _appDbContext.Set<SubscriptionPeriod>().FirstOrDefault(s => s.Id == periodId);
        }
    }
}
