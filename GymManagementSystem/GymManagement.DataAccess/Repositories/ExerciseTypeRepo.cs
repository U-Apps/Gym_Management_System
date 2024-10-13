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
    internal class ExerciseTypeRepo(AppDbContext _appDbContext) : IExerciseTypeRepo
    {
        public ExerciseType? GetTypeById(int id)
        {
            return _appDbContext.Set<ExerciseType>().AsNoTracking().FirstOrDefault(p => p.ExerciseTypeId == id);
        }

        public IEnumerable<ExerciseType> GetTypes()
        {
            return _appDbContext.Set<ExerciseType>().AsNoTracking().ToList();
        }
    }
}
