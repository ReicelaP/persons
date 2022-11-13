using Persons.Core.Models;
using System.Web.WebPages.Html;

namespace PersonsWeb.Models
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Users = new List<User>();
            Person = new AddPersonViewModel();
            DropDownList = new List<SelectListItem>();
        }
        public List<User> Users { get; set; }

        public AddPersonViewModel Person { get; set; }

        public List<SelectListItem> DropDownList { get; set; }
    }
}
