
using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;

namespace Jym_Management_BussinessLayer.Services
{
    public class ExerciseTypeService : IBaseServices<ExerciseType>
    {
        

        public IUnitOfWork _unit => new UnitOfWork(new AppDbContext());

        public void Add(ExerciseType module)
        {
            var tbExerciseType = Mapping.Mapper.Map<TbExerciseType>(module);
            _unit.ExerciseTypes.Add(tbExerciseType);
        }

        public void AddRange(IEnumerable<ExerciseType> module)
        {
            var tbExerciseType = Mapping.Mapper.Map<IEnumerable<TbExerciseType>>(module);
            _unit.ExerciseTypes.AddRange(tbExerciseType);
        }

        public void Delete(ExerciseType module)
        {
            var tbExerciseType = Mapping.Mapper.Map<TbExerciseType>(module);
            _unit.ExerciseTypes.Delete(tbExerciseType);
        }

        public void DeleteById(int id)
        {
            _unit.Employees.DeleteById(id);
            int x = _unit.Complete();
        }

        public void DeleteRange(IEnumerable<ExerciseType> modules)
        {
            var tbExerciseType = Mapping.Mapper.Map<IEnumerable<TbExerciseType>>(modules);
            _unit.ExerciseTypes.DeleteRange(tbExerciseType);
        }

        public ExerciseType Find(Func<ExerciseType, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbExerciseType, bool>>(predicate);
            return Mapping.Mapper.Map<ExerciseType>(_unit.ExerciseTypes.Find(exp));
        }

        public IEnumerable<ExerciseType> FindAll(Func<ExerciseType, bool> predicate)
        {
            var exp = Mapping.Mapper.Map<Func<TbExerciseType, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<ExerciseType>>(_unit.ExerciseTypes.FindAll(exp));
        }

        public IEnumerable<ExerciseType> GetAll()
        {
            return Mapping.Mapper.Map<IEnumerable<ExerciseType>>(_unit.ExerciseTypes.GetAll());
        }

        public ExerciseType GetById(int id)
        {
            return Mapping.Mapper.Map<ExerciseType>(_unit.ExerciseTypes.GetById(id));
        }

        public void Update(ExerciseType module)
        {
            _unit.ExerciseTypes.Update(Mapping.Mapper.Map<TbExerciseType>(module));
        }
    }
}
