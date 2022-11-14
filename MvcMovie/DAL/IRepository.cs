namespace MvcMovie.DAL
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void insert(T obj);
        void update(T obj);
        void delete(int id);
        void Save();
    }
}
