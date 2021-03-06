﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace DEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string user = JsonConvert.SerializeObject(new { name= "hi" });
            HttpContext.Session.Set("UserInfo", Encoding.UTF8.GetBytes(user));

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
