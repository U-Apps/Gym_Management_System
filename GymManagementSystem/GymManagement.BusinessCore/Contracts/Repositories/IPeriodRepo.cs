using GymManagement.BusinessCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.BusinessCore.Contracts.Repositories
{
    public interface IPeriodRepo
    {
        public IEnumerable<Period> GetPeriods();
        public Period? GetPeriodById(int id);
    }
}
