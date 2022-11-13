using Persons.Core.Models;
using Persons.Core.Services;
using Persons.Data;

namespace Persons.Services
{
    public class UserService : EntityService<User>, IUserService
    {
        public UserService(IPersonsDbContext context) : base(context)
        {
        }

        public void CreateUser(Person person)
        {
            var user = new User();
            user.FullName = $"{person.FirstName} {person.LastName}";
            user.Age = DateTime.Now.Year - person.BirthDate.Year;
            user.Action = "";

            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User GetUser(int id)
        {
            return _context.Users.Find(id);
        }
    }
}
