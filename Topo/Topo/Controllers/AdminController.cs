using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Topo.Model;

namespace Topo.Controllers
{
    public class AdminController : Controller
    {
        public readonly EFCContext Context;

        public AdminController(EFCContext context)
        {
            Context = context;
        }


        public IActionResult Panel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddRegion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRegion(Region model)
        {
            return Content($"{model.Name}\n" +
                $"{model.Description}\n" +
                $"{model.PostionLat}\n" +
                $"{model.PostionLat}");
        }


    }
}