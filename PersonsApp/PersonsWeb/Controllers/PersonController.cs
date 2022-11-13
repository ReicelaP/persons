using Microsoft.AspNetCore.Mvc;
using Persons.Core.Models;
using Persons.Core.Services;
using PersonsWeb.Models;
using System.Web.WebPages.Html;

namespace PersonsWeb.Controllers
{
    public class PersonController : Controller
    {
        private readonly IEntityService<Person> _personService;
        private readonly IUserService _userService;

        public PersonController
            (IEntityService<Person> personService, 
            IUserService userService)
        {
            _personService = personService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            List<User> users = _userService.GetAll();
            return View(new PersonViewModel { Users = users});
        }

        public IActionResult Create()
        {
            var person = new AddPersonViewModel();
            return PartialView("PersonPartialView", person);
        }

        [HttpPost]
        public IActionResult Create(AddPersonViewModel personModel)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("PersonPartialView", personModel);
            }

            var person = new Person();
            person.FirstName = personModel.FirstName;
            person.LastName = personModel.LastName;
            person.BirthDate = personModel.BirthDate;
            person.PhoneNumber = string.Join(",", personModel.PhoneNumber);
            person.Address = string.Join(",", personModel.Address);

            _personService.Create(person);
            _userService.CreateUser(person);

            return RedirectToAction("Index", "Person");
        }

        [HttpPost]
        public IActionResult UpdateUser(User user)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var allDbUsers = _userService.GetAll();

            foreach (var dbUser in allDbUsers)
            {
                list.Add(new SelectListItem() { Text = $"{dbUser.FullName} ({dbUser.Age})", Value = $"Married ({dbUser.FullName})" });
            }

            new PersonViewModel { DropDownList = list };


            var found = _userService.GetUser(user.Id);
            found.Action = user.Action;       
            _userService.Update(found);

            return View("Index", "Person");
        }
    }
}
