using Business.Concrete;
using DataAccess.Ef;
using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.ViewComponents.Default
{
    public class SubAbout: ViewComponent
    {
        SubAboutManager sm = new SubAboutManager(new EfSubAboutDal()); 
        public IViewComponentResult Invoke()
        {
            var values = sm.GetList();
            return View(values);
        }
    }
}
