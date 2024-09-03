﻿
using Jym_Management_BussinessLayer.AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories;
using Jym_Management_DataAccessLayer.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Jym_Management_BussinessLayer.Services
{
    public class ExerciseTypeService : IBaseServices<ExerciseType>
    {
        

        

        public int Add(ExerciseType module)
        {
            IBaseRepository<TbExerciseType> repo = new BaseRepository<TbExerciseType>(new AppDbContext());
            var tbExerciseType = Mapping.Mapper.Map<TbExerciseType>(module);
            repo.Add(tbExerciseType);
            repo.SaveChanges();
            repo.Dispose();
            return tbExerciseType.ExerciseTypeId;
        }

        public void AddRange(IEnumerable<ExerciseType> module)
        {
            IBaseRepository<TbExerciseType> repo = new BaseRepository<TbExerciseType>(new AppDbContext());
            var tbExerciseType = Mapping.Mapper.Map<IEnumerable<TbExerciseType>>(module);
            repo.AddRange(tbExerciseType);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void Delete(ExerciseType module)
        {
            IBaseRepository<TbExerciseType> repo = new BaseRepository<TbExerciseType>(new AppDbContext());
            var tbExerciseType = Mapping.Mapper.Map<TbExerciseType>(module);
            repo.Delete(tbExerciseType);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void DeleteById(int id)
        {
            IBaseRepository<TbExerciseType> repo = new BaseRepository<TbExerciseType>(new AppDbContext());
            repo.DeleteById(c=>c.ExerciseTypeId==id);
            repo.SaveChanges();
            repo.Dispose();
        }

        public void DeleteRange(IEnumerable<ExerciseType> modules)
        {
            IBaseRepository<TbExerciseType> repo = new BaseRepository<TbExerciseType>(new AppDbContext());
            var tbExerciseType = Mapping.Mapper.Map<IEnumerable<TbExerciseType>>(modules);
            repo.DeleteRange(tbExerciseType);
            repo.SaveChanges();
            repo.Dispose();
        }

        public ExerciseType Find(Expression<Func<ExerciseType, bool>> predicate)
        {
            IBaseRepository<TbExerciseType> repo = new BaseRepository<TbExerciseType>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Expression<Func<TbExerciseType, bool>>>(predicate);
            return Mapping.Mapper.Map<ExerciseType>(repo.Find(exp));
        }

        public IEnumerable<ExerciseType> FindAll(Func<ExerciseType, bool> predicate)
        {
            IBaseRepository<TbExerciseType> repo = new BaseRepository<TbExerciseType>(new AppDbContext());
            var exp = Mapping.Mapper.Map<Func<TbExerciseType, bool>>(predicate);
            return Mapping.Mapper.Map<IEnumerable<ExerciseType>>(repo.FindAll(exp));
        }

        public IEnumerable<ExerciseType> GetAll()
        {
            IBaseRepository<TbExerciseType> repo = new BaseRepository<TbExerciseType>(new AppDbContext());
            return Mapping.Mapper.Map<IEnumerable<ExerciseType>>(repo.GetAll());
        }

        public ExerciseType GetById(int id)
        {
            IBaseRepository<TbExerciseType> repo = new BaseRepository<TbExerciseType>(new AppDbContext());
            return Mapping.Mapper.Map<ExerciseType>(repo.GetById(c=>c.ExerciseTypeId==id));
        }

        public void Update(ExerciseType module)
        {
            IBaseRepository<TbExerciseType> repo = new BaseRepository<TbExerciseType>(new AppDbContext());
            repo.Update(Mapping.Mapper.Map<TbExerciseType>(module));
            repo.SaveChanges();
            repo.Dispose();
        }
    }
}
