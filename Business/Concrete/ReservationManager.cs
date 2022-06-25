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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public IResult Add(Reservation entity)
        {
            _reservationDal.Insert(entity);
            return new SuccessResult();
        }

        public IResult Delete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public Reservation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
