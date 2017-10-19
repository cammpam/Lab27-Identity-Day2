using Lab27Cameron.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27Cameron.Controllers
{
    public class HomeController : Controller
    {
        private readonly Lab27CameronContext _context;

        public HomeController(Lab27CameronContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

        return View();

        }
    }
}
