using GenericApi.Core.BaseModel;
using GenericApi.Model.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenericApi.Model.Repositories
{
    public interface IBaseRepository<T> 
    {
        IQueryable<T> Query();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }

    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, IBase
    {
        protected readonly IDbContext _context;
        protected readonly DbSet<T> _set;
        public BaseRepository(IDbContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }
        public virtual IQueryable<T> Query()
        {
            return _set.AsQueryable();
        }
        public virtual async Task<T> Add(T entity)
        {
            var result = await _set.AddAsync(entity);
            await _context.SaveChangesAsync();

            return result.Entity;
        }
        public virtual async Task<T> Delete(int id)
        {
            var entity = await Get(id);

            var result = _set.Remove(entity);
            await _context.SaveChangesAsync();

            return result.Entity;
        }
        public virtual async Task<T> Get(int id)
        {
            var entity = await _set.Where(x=> x.Id == id).FirstOrDefaultAsync();
            return entity;
        }
        public virtual async Task<T> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
