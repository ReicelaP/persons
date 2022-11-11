using Persons.Core.Models;

namespace Persons.Core.Services
{
    public interface IUserService : IEntityService<User>
    {
        void CreateUser(Person person);
    }
}
