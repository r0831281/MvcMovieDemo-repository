using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MvcMovie.DAL;
using MvcMovie.Data;

namespace MvcMovie.DAL
{
    public class GenericRepository<T> : IRepository<T> where T:class
    {
        private MovieContext _context;
        private DbSet<T> table = null;

        public GenericRepository(MovieContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public void delete(int id)
        {
            var toGo = table.Find(id);
            table.Remove(toGo);
        }

        public IEnumerable<T> GetAll()
        {
            var list = table.ToList();
            return list;
        }

        public T GetById(int id)
        {
            var item = table.Find(id);
            return item;
        }

        public void insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void update(T obj)
        {
           table.Update(obj);
        }
    }
}
