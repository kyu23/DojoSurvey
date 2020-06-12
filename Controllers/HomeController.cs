using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey2.Models;

namespace DojoSurvey2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("results")]
        public IActionResult Submission(Survey newSurvey)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine($"{newSurvey.Name} | {newSurvey.Location} | {newSurvey.Language} | {newSurvey.Comment}");
                ViewBag.Survey = newSurvey;
                return View("Results");
            }
            else{
                return View("Index");
            }
        }
        
    }
}
