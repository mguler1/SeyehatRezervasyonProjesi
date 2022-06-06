using Business.Concrete;
using DataAccess.Ef;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult DestinationDetail(int id)
        {
            var values = destinationManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetail(Destination parameters)
        {
            return View();
        }
    }
}
