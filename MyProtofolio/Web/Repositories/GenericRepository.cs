using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _Context;
        private DbSet<T> _dbSet = null;
        public GenericRepository(DataContext Context)
        {
            _Context = Context;
            _dbSet = _Context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(T item)
        {
            _dbSet.Add(item);
        }

        public void Update(T item)
        {
            _dbSet.Attach(item);
            _Context.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            T existing = GetById(id);
            _dbSet.Remove(existing);
        }



    }
}
