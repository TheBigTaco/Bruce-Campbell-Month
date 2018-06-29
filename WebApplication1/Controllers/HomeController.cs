using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BruceCampbellMonth.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/forum")]
        public ActionResult Forum()
        {
            return View();
        }

        [HttpGet("/calendar")]
        public ActionResult Calendar()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
