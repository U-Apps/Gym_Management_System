
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_BussinessLayer.SingleUnitOFWork;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class ExerciseTypeService : IBaseServices<ExerciseType>
    {
        public UnitOfWorkBuissness _unitOfWork => UnitOfWorkBuissness.getInstenece();

        public void Add(ExerciseType module)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<ExerciseType> module)
        {
            throw new NotImplementedException();
        }

        public void Delete(ExerciseType module)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<ExerciseType> modules)
        {
            throw new NotImplementedException();
        }

        public ExerciseType Find(Func<ExerciseType, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExerciseType> FindAll(Func<ExerciseType, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExerciseType> GetAll()
        {
            throw new NotImplementedException();
        }

        public ExerciseType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ExerciseType module)
        {
            throw new NotImplementedException();
        }
    }
}
