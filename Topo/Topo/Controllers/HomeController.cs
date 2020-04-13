using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Topo.Model;

namespace Topo.Controllers
{
    public class HomeController : Controller
    {
        public readonly EFCContext Context;

        public HomeController(EFCContext context)
        {
            Context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Mapa()
        {
            return View();
        }

        public IActionResult Kontakt()
        {
            return View();
        }
    }
}