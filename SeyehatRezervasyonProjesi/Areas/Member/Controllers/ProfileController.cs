using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SeyehatRezervasyonProjesi.Areas.Member.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SeyehatRezervasyonProjesi.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
       
        private readonly UserManager<AppUser>_userManager;
        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values=await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel=new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.SurName = values.Surname;
            userEditViewModel.Mail = values.Email;
            userEditViewModel.PhoneNumber = values.PhoneNumber;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (model.Image!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(model.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/UserImages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await model.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            user.Name=model.Name;
            user.Surname=model.SurName;
            user.PasswordHash=_userManager.PasswordHasher.HashPassword(user,model.Password);
           var result=await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }
            return View();
        }
    }
}
