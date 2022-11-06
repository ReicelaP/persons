using Persons.Core.Models;

namespace PersonsWeb.Models
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Users = new List<User>();
            Person = new Person();
        }
        public List<User> Users { get; set; }
        public Person Person { get; set; }
    }
}
