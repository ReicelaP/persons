using Persons.Core.Models;
using Persons.Core.Services;
using Persons.Data;

namespace Persons.Services
{
    public class EntityService<T> : CrudService, IEntityService<T> where T : Entity
    {
        public EntityService(IPersonsDbContext context) : base(context)
        {
        }

        public void Create(T entity)
        {
            Create<T>(entity);
        }

        public void Update(T entity)
        {
            Update<T>(entity);
        }

        public List<T> GetAll()
        {
            return GetAll<T>();
        }

        public void Delete(T entity)
        {
            Delete<T>(entity);
        }

        public IQueryable<T> Query()
        {
            return Query<T>();
        }
    }
}
