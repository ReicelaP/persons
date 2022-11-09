using Persons.Core.Models;

namespace PersonsWeb.Models
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Users = new List<User>();
            Person = new AddPersonViewModel();
        }
        public List<User> Users { get; set; }
        public AddPersonViewModel Person { get; set; }
    }
}
