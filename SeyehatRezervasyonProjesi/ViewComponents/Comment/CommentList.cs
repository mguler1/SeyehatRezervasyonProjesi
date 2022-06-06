using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.ViewComponents.Comment
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
