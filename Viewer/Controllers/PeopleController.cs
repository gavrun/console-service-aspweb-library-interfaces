// connect
using Common;
using Library;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Viewer.Controllers
{
    public class PeopleController : Controller
    {
        //
        PersonReader reader = new PersonReader();

        // get data by not abstract type
        public IActionResult UseConcreteType()
        {
            List<Person> people = reader.GetPeople();

            ViewData["Title"] = "Using Concrete Type";
            //return View("Index", null);
            return View("Index", people);
        }

        // get data by abstract type
        public IActionResult UseAbstractType()
        {
            IEnumerable<Person> people = reader.GetPeople();

            ViewData["Title"] = "Using Abstract Type";
            //return View("Index", null);
            return View("Index", people);
        }
    }
}
