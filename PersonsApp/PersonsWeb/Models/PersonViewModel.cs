using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IEnumerable<SelectListItem> DropDownList => 
            Users.Select(user => new SelectListItem
            {
                Text = $"{user.FullName} ({user.Age})",
                Value = user.FullName}).ToList();
    }
}

