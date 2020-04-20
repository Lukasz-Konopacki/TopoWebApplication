using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Topo.Model;

namespace Topo.Controllers
{
    public class ClimbingController : Controller
    {
        public readonly EFCContext Context;

        public ClimbingController(EFCContext context)
        {
            Context = context;
        }

        public IActionResult Regions()
        {
            List<Region> model = Context.Regions.ToList<Region>();

            return View(model);
        }

        public IActionResult Region(int id)
        {
            Region model = Context.Regions.FirstOrDefault(x => x.Id == id);

            return View(model);
        }

    }
}