﻿
using FG_CoreAPI.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FG_CoreAPI.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task Add(T entity)
        {
            await context.Set<T>().AddAsync(entity);
        }

        public async Task Delete(int Entity)
        {
            var exist =await context.Set<T>().FindAsync(Entity);
            context.Remove(exist);
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression);            
        }

        public async Task<List<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }
         
        public async Task<T> GetbyId(int entity)
        {
            return await context.Set<T>().FindAsync(entity);
        }

        public void Update(T Entity)
        {
            context.Entry(Entity).State = EntityState.Modified;
        }
    }
}
