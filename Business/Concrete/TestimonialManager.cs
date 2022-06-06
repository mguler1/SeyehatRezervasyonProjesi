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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }
        public IResult Add(Testimonials entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Testimonials entity)
        {
            throw new NotImplementedException();
        }

        public Testimonials GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonials> GetList()
        {
            return _testimonialDal.GetList();
        }

        public IResult Update(Testimonials entity)
        {
            throw new NotImplementedException();
        }
    }
}
