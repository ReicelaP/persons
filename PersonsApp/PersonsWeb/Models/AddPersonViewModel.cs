using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonsWeb.Models
{
    public class AddPersonViewModel
    {
        public AddPersonViewModel()
        {
            PhoneNumber = new List<string>();
            Address = new List<string>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public IList<string> PhoneNumber { get; set; }

        public IList<string> Address { get; set; }

        public string Primary { get; set; }
    }
}
