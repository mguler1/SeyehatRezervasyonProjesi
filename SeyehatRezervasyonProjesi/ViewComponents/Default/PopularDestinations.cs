using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.ViewComponents.Default
{
    public class PopularDestinations:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
