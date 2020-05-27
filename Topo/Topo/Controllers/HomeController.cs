using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Topo.Model;
using Topo.ViewModel;

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
            IndexViewModel model = new IndexViewModel();

            var Regions = Context.Regions.Include(x => x.Photo).Where(x => x.Id <= 4).ToList<Region>();
            model.Regions = Regions;

            return View(model);
        }

        public IActionResult Mapa()
        {
            var model = Context.Regions.ToList<Region>();


            return View(model);
        }

        public IActionResult Kontakt()
        {
            return View();
        }
    }
}