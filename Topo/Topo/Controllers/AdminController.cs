using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Topo.Model;
using Topo.ViewModel;

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


        public IActionResult DeleteRegion()
        {
            List<Region> model = Context.Regions.ToList();

            return View(model);
        }

        public IActionResult ConfirmDelete(int id)
        {
            Region model = Context.Regions.FirstOrDefault(x => x.Id == id);

            return View(model);
        }

        [HttpGet]
        public IActionResult AddRegion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRegion(SaveRegionViewModel model)
        {
            using (var stream = System.IO.File.Create($"wwwroot/img/{model.Name}.jpg"))
            {
                model.File.CopyTo(stream);
            }

            Image img = new Image()
            {
                Name = model.Name,
                Url = $"img/{model.Name}.jpg"
            };
            Context.Images.Add(img);
            Context.SaveChanges();


            Region region = new Region()
            {
                Name = model.Name,
                Description = model.Description,
                PostionLat = model.PostionLat,
                PostionLng = model.PostionLng,
                Photo = img
            };

            Context.Regions.Add(region);

            Context.SaveChanges();

            return Content($"{model.File.FileName}");
        }


    }
}