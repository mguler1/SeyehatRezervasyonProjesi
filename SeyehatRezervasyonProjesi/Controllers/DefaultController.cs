using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
