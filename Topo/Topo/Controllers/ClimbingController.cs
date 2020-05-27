using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Topo.Model;
using Topo.ViewModel;

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
            List<Region> model = Context.Regions.Include(x => x.Photo).ToList<Region>();

            return View(model);
        }

        public IActionResult Region(int id)
        {
            Region Region = Context.Regions.Include(x => x.Rocks).ThenInclude(x => x.Routes).Include(x => x.Photo).FirstOrDefault(x => x.Id == id);
            var model = new RegionViewModel(Region);

            return View(model);
        }

        public IActionResult Rock(int id)
        {
            var model = Context.Rocks.Include(x => x.Routes).Include(x => x.Photos).FirstOrDefault(x => x.Id == id);

            return View(model);
        }
    }
}