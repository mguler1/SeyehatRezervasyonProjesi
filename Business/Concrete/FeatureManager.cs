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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }
        public IResult Add(Feature entity)
        {
            _featureDal.Insert(entity);
            return new SuccessResult();
        }

        public IResult Delete(Feature entity)
        {
            _featureDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<Feature> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetList()
        {
            return _featureDal.GetList();
        }

        public IResult Update(Feature entity)
        {
            _featureDal.Update(entity);
            return new SuccessResult();
        }
    }
}
