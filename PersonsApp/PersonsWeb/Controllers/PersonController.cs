using Microsoft.AspNetCore.Mvc;
using Persons.Core.Models;
using Persons.Data;
using Persons.Services;
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
            //List<Person> persons = _context.Persons.ToList();
            //return View(persons);

            List<User> users = _context.Users.ToList();
            return View(new PersonViewModel { Users = users});
        }

        public IActionResult Create()
        {
            var person = new Person();
            return PartialView("PersonPartialView", person);
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            _context.Persons.Add(person);

            var user = new User();
            user.FullName = $"{person.FirstName} {person.LastName}";
            user.Age = DateTime.Now.Year - person.BirthDate.Year;
            user.Action = null;
            _context.Users.Add(user);

            _context.SaveChanges();
            return RedirectToAction("Index", "Person");
        }
    }
}
