﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Jym_Management_DataAccessLayer.Data;
using Jym_Management_DataAccessLayer.Repositories;

namespace Jym_Management_BussinessLayer.Services.Base
{
    public interface IBaseServices<T> where T : class
    {

        int Add(T module);
        void AddRange(IEnumerable<T> module);
        T GetById(int id);
        IEnumerable<T>GetAll();
        T Find(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindAll(Func<T, bool> predicate);
        void Delete(T module);
        void DeleteRange(IEnumerable<T> modules);
        void DeleteById(int id);
        void Update(T module);

    }

}
