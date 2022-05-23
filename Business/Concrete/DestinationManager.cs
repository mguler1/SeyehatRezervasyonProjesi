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
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;
        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }
        public IResult Add(Destination entity)
        {
            _destinationDal.Insert(entity);
            return new SuccessResult();
        }

        public IResult Delete(Destination entity)
        {
            _destinationDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<Destination> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Destination> GetList()
        {
            return _destinationDal.GetList();
        }

        public IResult Update(Destination entity)
        {
            _destinationDal.Update(entity);
            return new SuccessResult();
        }
    }
}

