using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exercice3.Controllers

{
    
        public class DisplayController : Controller
        {
            public IActionResult Index()
            {
                string firstName = "Gilbert";
                int age = 24;

            List<string> hobbies = new List<string>
            {
                "Football",
                "Lecture",
                "Voyage"
            };

                ViewData["FirstName"] = firstName;
                ViewData["Age"] = age;
                ViewData["Hobbies"] = hobbies;

                return View();
            }
        }
    }



