using System.Linq;


namespace DataLayer.Repositories
{
    interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll(string includeProperties = "");
        void Add(T item);
        void Delete(int id);
    }
}
