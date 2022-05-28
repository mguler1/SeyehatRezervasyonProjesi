using Business.Concrete;
using DataAccess.Ef;
using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.ViewComponents.Default
{
    public class Feature: ViewComponent
    {
        FeatureManager fm = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            ViewBag.Image ="aa";
            return View();
        }
    }
}
