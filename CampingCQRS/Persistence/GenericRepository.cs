using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Model;

namespace Persistence
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly IDbContextFactory<CampingContext> _context;

        public GenericRepository(IDbContextFactory<CampingContext> context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            using var context = _context.CreateDbContext();
            context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            using var context = _context.CreateDbContext();
            context.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            using var context = _context.CreateDbContext();
            return context.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            using var context = _context.CreateDbContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = _context.CreateDbContext();
            return context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            using var context = _context.CreateDbContext();
            context.Set<T>().Remove(entity);
        }
    }
}
