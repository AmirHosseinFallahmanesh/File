using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    public class ProfileController : Controller
    {
        [Route("User")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("User/Create")]
        public IActionResult Create()
        {
            return View();
        }


        [Route("User/{id:int}")]
        public IActionResult Get(int id)
        {
            return View();
        }

        [Route("User/{EmployeeNumber:minlength(4)}")]
        public IActionResult Get(string EmployeeNumber)
        {
            return View();
        }
    }
}