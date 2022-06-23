using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
