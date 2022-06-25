using Business.Concrete;
using DataAccess.Ef;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace SeyehatRezervasyonProjesi.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());
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
            List<SelectListItem> values = (from x in destinationManager.GetList()
                                           select new SelectListItem
                                           {
                                               Text=x.City  ,
                                               Value=x.DestinationId.ToString()
                                           }).ToList();
            ViewBag.Values = values;
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation model)
        {
            model.AppUserId = 3;
            reservationManager.Add(model);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
