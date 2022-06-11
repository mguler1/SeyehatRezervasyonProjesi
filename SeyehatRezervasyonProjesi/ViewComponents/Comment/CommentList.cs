using Business.Concrete;
using DataAccess.Ef;
using Microsoft.AspNetCore.Mvc;

namespace SeyehatRezervasyonProjesi.ViewComponents.Comment
{
    public class CommentList:ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetDestinationById(id);    
            return View(values);
        }
    }
}
