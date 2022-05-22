using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.ViewComponents.Default
{
    public class Slider:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
