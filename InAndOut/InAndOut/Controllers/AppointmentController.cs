using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            bool f = Details(2).Value;
            return View();
        }

        public ActionResult<bool> Details(int id)
        {
            return Ok(true);
        }
    }
}
 