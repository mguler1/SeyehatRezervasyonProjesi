using Business.Abstarct;
using Core.Result.Abstarct;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager (ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public IResult Add(Comment entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }
        public List<Comment> GetDestinationById(int id)
        {
         return _commentDal.GetListFilter(x=>x.DestinationId==id);
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
