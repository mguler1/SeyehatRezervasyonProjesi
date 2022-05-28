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
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;
        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }
        public IResult Add(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SubAbout> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> GetList()
        {
            return _subAboutDal.GetList();
        }

        public IResult Update(SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
