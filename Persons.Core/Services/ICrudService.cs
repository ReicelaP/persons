using Persons.Core.Models;

namespace Persons.Core.Services
{
    public interface ICrudService
    {
        void Create<T>(T entity) where T : Entity;
        void Update<T>(T entity) where T : Entity;
        List<T> GetAll<T>() where T : Entity;
        void Delete<T>(T entity) where T : Entity;
        IQueryable<T> Query<T>() where T : Entity;

    }
}
