namespace Persons.Core.Models
{
    public class User : Entity
    {
        public string FullName { get; set; }

        public int Age { get; set; }

        public string Action { get; set; }
    }
}
