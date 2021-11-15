using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    public class AccountController : Controller
    {
        //acount/login
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }


        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}