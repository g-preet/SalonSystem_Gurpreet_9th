using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SalonSystem_Gurpreet.Controllers
{
    public class StaffAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
