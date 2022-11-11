using Persons.Core.Models;

namespace Persons.Core.Services
{
    public interface IEntityService<T> where T : Entity
    {
        void Create(T entity);
        void Update(T entity);
        List<T> GetAll();
        void Delete(T entity);
        IQueryable<T> Query();
    }
}
