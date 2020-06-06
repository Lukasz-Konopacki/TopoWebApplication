using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            return RedirectToAction("panel", "admin");
        }

        public IActionResult ChoseRegionToChange()
        {
            List<Region> model = Context.Regions.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult ChangeRegionForm(int id)
        {
            var region = Context.Regions.FirstOrDefault(x => x.Id == id);

            var model = new SaveRegionViewModel()
            {
                Id = region.Id,
                Name = region.Name,
                Description = region.Description,
                PostionLat = region.PostionLat,
                PostionLng = region.PostionLng
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ChangeRegionForm(SaveRegionViewModel model)
        {
            var Region = Context.Regions.Include(x => x.Photo).FirstOrDefault(x => x.Id == model.Id);
            Region.Name = model.Name;
            Region.Description = model.Description;
            Region.PostionLat = model.PostionLat;
            Region.PostionLng = model.PostionLng;

            if(model.File != null)
            {
                System.IO.File.Delete($"wwwroot/{Region.Photo.Url}");
                Context.Images.Remove(Region.Photo);

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

                Region.Photo = img;
            }

            Context.Regions.Update(Region);
            Context.SaveChanges();
            return RedirectToAction("Panel");
        }

        public IActionResult ChoseRegionToDelete()
        {
            List<Region> model = Context.Regions.ToList();
            return View(model);
        }

        public IActionResult ConfirmRegionDelete(int id)
        {
            Region model = Context.Regions.Include(x => x.Photo).FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        public IActionResult DeleteRegion(int id)
        {
            var region = Context.Regions.Include(x => x.Photo).Single(x => x.Id == id);
            var img = region.Photo;

            System.IO.File.Delete($"wwwroot/{img.Url}");

            Context.Regions.Remove(region);
            Context.Images.Remove(img);
            Context.SaveChanges();
            return RedirectToAction("panel", "admin");
        }
    }
}