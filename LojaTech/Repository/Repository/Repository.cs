using LojaTech.Data;
using LojaTech.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LojaTech.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _entity;

        public Repository(AppDbContext context)
        {
            _context = context;
            _entity = _context.Set<T>();
            //_entity = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entity.ToListAsync();
        }

        //public async Task<T?> GetIdAsync(Expression<Func<T, bool>> predicate)
        //{
        //    return await _entity.FirstOrDefaultAsync(predicate);
        //}

        public async Task<T> AddAsync(T entity)
        {
            await _entity.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _entity.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            _entity.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}