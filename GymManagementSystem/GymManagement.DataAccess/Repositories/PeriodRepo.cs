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
    internal class PeriodRepo(AppDbContext _appDbContext) : IPeriodRepo
    {
        public IEnumerable<Period> GetPeriods()
        {
            return _appDbContext.Set<Period>().AsNoTracking().ToList();
        }
    }
}
