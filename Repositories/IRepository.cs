using System.Collections.Generic;

namespace KalaRintikTea.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T? GetById(int id);
        int Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
