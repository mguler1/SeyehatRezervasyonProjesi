using Business.Abstarct;
using Core.Result.Abstarct;
using Core.Result.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public IResult Add(About entity)
        {
            _aboutDal.Insert(entity);
            return new SuccessResult();
        }

        public IResult Delete(About entity)
        {
            _aboutDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<About> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<About>> GetList()
        {
            return new SuccessDataResult<List<About>>(_aboutDal.GetList());
        }

        public IResult Update(About entity)
        {
            _aboutDal.Update(entity);
            return new SuccessResult();
        }
    }
}