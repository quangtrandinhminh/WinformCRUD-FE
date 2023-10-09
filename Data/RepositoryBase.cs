using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class RepositoryBase<T> where T : class
    {
        readonly ElectricStoreDBContext _context;
        readonly DbSet<T> _dbSet;
        public RepositoryBase()
        {
            _context = new ElectricStoreDBContext();
            _dbSet = _context.Set<T>();

        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        // Queryable: https://docs.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1?view=net-5.0
        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }
        
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        
        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

