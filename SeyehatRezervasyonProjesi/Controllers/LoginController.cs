using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SeyehatRezervasyonProjesi.Models;
using System.Threading.Tasks;

namespace SeyehatRezervasyonProjesi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public LoginController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public async Task<IActionResult> SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel appUser)
        {
            AppUser user = new AppUser()
            {
                Name = appUser.Name,
                Surname = appUser.Surname,
                Email = appUser.Mail,
                UserName = appUser.Username
            };
            if (appUser.Password == appUser.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(user, appUser.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(appUser);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }

}
