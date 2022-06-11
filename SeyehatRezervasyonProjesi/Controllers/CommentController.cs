using Business.Concrete;
using DataAccess.Ef;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SeyehatRezervasyonProjesi.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult AddComment(Comment comment)
        {
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.Commentstate =true;
            commentManager.Add(comment);
            return PartialView();
        }
    }
}
