using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SeyehatRezervasyonProjesi.ViewComponents.Default
{
    public class Statics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var context=new Context();
            ViewBag.Rotalar = context.Destinations.Count();
            ViewBag.Rehberler = context.Guides.Count();

            return View();
        }
    }
}
