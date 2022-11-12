using System.ComponentModel.DataAnnotations;

namespace Persons.Core.Models
{
    public class Person : Entity
    {
        [Required(ErrorMessage = "Name is required.")]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime BirthDate { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string Address { get; set; }
    }
}
