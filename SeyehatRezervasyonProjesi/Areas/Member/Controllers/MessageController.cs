using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
