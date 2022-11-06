namespace PersonsWeb.Models
{
    public class AddPersonViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public IList<string> PhoneNumber { get; set; }

        public IList<string> Address { get; set; }
    }
}
