﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazorUI.services
{
    public interface IGenericRepository<T> where T:class
    {
        Task<List<T>> GetAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        Task<T> GetbyId(int entity);
        bool Update(T Entity);
        Task Add(T entity);
        void Delete(T Entity);
        Task Save();
    }
}
