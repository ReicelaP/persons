using Microsoft.AspNetCore.Mvc;
using Persons.Core.Models;
using Persons.Data;
using PersonsWeb.Models;

namespace PersonsWeb.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonsDbContext _context;

        public PersonController(PersonsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<User> users = _context.Users.ToList();
            return View(new PersonViewModel { Users = users});
        }

        public IActionResult Create()
        {
            var person = new AddPersonViewModel();
            return PartialView("PersonPartialView", person);
        }

        [HttpPost]
        public IActionResult Create(AddPersonViewModel personModel, string btn)
        {
            if(btn == "Cancel")
            {
                return RedirectToAction("Index", "Person");
            }

            var person = new Person();
            person.FirstName = personModel.FirstName;
            person.LastName = personModel.LastName;
            person.BirthDate = personModel.BirthDate;
            person.PhoneNumber = string.Join(",", personModel.PhoneNumber);
            person.Address = string.Join(",", personModel.Address);

            _context.Persons.Add(person);

            var user = new User();
            user.FullName = $"{person.FirstName} {person.LastName}";
            user.Age = DateTime.Now.Year - person.BirthDate.Year;
            user.Action = "single";
            _context.Users.Add(user);

            _context.SaveChanges();
            return RedirectToAction("Index", "Person");
        }

        public IActionResult AddPhoneNr()
        {
            return PartialView("PhoneNrPartialView");
        }
    }
}
