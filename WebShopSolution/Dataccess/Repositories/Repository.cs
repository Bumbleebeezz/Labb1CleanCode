using Dataccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly WebShopDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(WebShopDbContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public T Get(int id)
        {
            return _dbSet.Find(id); // Assumes that T is an entity with a primary key of type int
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList(); // Returns all entities of type T as a list
        }

        public void Remove(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }

        public void Update(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }

            _dbSet.Update(item);
            _context.SaveChanges();
        }
    }
}
