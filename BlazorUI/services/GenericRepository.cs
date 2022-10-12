using BlazorUI.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorUI.services
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
            context.Set<T>().Add(entity);
            await Save();
        }

        public  void Delete(T Entity)
        {
            
             context.Remove(Entity);
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression);
         }

        public async Task<List<T>> GetAll()
        {
            return await context.Set<T>(). ToListAsync();
        }

        public async Task<T> GetbyId(int entity)
        {
            return await context.Set<T>().FindAsync(entity);
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }

        public bool Update(T Entity)
        {
            context.Entry(Entity).State = EntityState.Modified;
            return true;
        }

        /*public void Update(T Entity)
        {
            context.Entry(Entity).State = EntityState.Modified;
        }*/
    }
}
