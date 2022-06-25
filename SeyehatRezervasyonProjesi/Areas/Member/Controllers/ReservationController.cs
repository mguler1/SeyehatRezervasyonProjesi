using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        [HttpGet]
        public IActionResult MyCurrentReservation()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MyOldReservation()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation model)
        {
            return View();
        }
    }
}
