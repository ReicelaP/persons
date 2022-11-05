using System.ComponentModel.DataAnnotations.Schema;

namespace Persons.Core.Models
{
    public class Person : Entity
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }
        
        public int PhoneNumber { get; set; }
        
        public string Address { get; set; }
    }
}
