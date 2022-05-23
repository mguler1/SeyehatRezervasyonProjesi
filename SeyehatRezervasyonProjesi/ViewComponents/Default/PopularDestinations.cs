using Business.Concrete;
using DataAccess.Ef;
using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.ViewComponents.Default
{
    public class PopularDestinations:ViewComponent
    {
        DestinationManager dm = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = dm.GetList();
            return View(values);
        }
    }
}
