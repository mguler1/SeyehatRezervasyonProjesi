using Business.Concrete;
using DataAccess.Ef;
using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.ViewComponents.Default
{
    public class Testimonial:ViewComponent
    {
        TestimonialManager tm = new TestimonialManager(new EfTestimonialsDal());
        public IViewComponentResult Invoke()
        {
            var values=tm.GetList();
            return View(values);
        }
    }
}
