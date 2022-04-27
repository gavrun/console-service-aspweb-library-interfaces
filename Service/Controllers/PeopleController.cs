using Common;
//connected
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Controllers
{
    // ?
    [ApiController]
    [Route("[controller]")]

    // ControllerBase class instead of Controller class
    public class PeopleController : ControllerBase
    {
        // ?
        private readonly ILogger<PeopleController> _logger;
        // ?
        private readonly IPeopleProvider _provider;

        // ?
        public PeopleController(IPeopleProvider provider,
            ILogger<PeopleController> logger)
        {
            _provider = provider;
            _logger = logger;
        }

        // ?
        [HttpGet]

        // ?
        public IEnumerable<Person> Get()
        {
            return _provider.GetPeople();
        }

        // ?
        [HttpGet("{id}")]

        //
        public Person Get(int id)
        {
            return _provider.GetPeople().First(p => p.Id == id);
        }


        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

    }
}
