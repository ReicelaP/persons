using Microsoft.EntityFrameworkCore;
using Persons.Core.Models;

namespace Persons.Data
{
    public class PersonsDbContext : DbContext, IPersonsDbContext
    {
        public PersonsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
