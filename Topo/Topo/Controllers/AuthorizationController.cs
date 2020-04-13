using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Topo.Model;
using Topo.ViewModel;

namespace Topo.Controllers
{
    public class AuthorizationController : Controller
    {
        protected UserManager<IdentityUser> UserManager { get; }
        public AuthorizationController(UserManager<IdentityUser> userManager)
        {
            UserManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public  async Task<IActionResult> Register(RegisterViewModel model)
        {

            if(ModelState.IsValid)
            {
                var user = new IdentityUser(model.Email) { Email = model.Email };
                var result = await UserManager.CreateAsync(user, model.Password);
                if(result.Succeeded)
                {
                    return Content("Udało się dodać użytkownika");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        public IActionResult LogIn()
        {
            return View();
        }

    }
}