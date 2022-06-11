using Business.Concrete;
using DataAccess.Ef;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SeyehatRezervasyonProjesi.ViewComponents.Comment
{
    public class CommentAdd: ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
       
        public IViewComponentResult Invoke()
        {
            return View();
        }

      
    }
}
