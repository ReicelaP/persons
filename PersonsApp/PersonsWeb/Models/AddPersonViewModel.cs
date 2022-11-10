using System.ComponentModel.DataAnnotations;

namespace PersonsWeb.Models
{
    public class AddPersonViewModel
    {
        public AddPersonViewModel()
        {
            PhoneNumber = new List<string>();
            Address = new List<string>();
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public IList<string> PhoneNumber { get; set; }

        [Required]
        public IList<string> Address { get; set; }

        public string Primary { get; set; }
    }
}
