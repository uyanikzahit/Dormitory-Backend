using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CafeteriaManager : ICafeteriaService
    {
        ICafeteriaDal _cafeteriaDal;

        public CafeteriaManager(ICafeteriaDal cafeteriaDal)
        {
            _cafeteriaDal = cafeteriaDal;
        }

        public IResult Add(Cafeteria cafeteria)
        {
            _cafeteriaDal.Add(cafeteria);
            return new SuccessResult();
        }

        public IDataResult<List<Cafeteria>> GetAll()
        {
            return new SuccessDataResult<List<Cafeteria>>(_cafeteriaDal.GetAll());
        }

        public IDataResult<Cafeteria> GetCafeteriaById(int cafeteriaId)
        {
            return new SuccessDataResult<Cafeteria>(_cafeteriaDal.Get(b => b.EatId == cafeteriaId));
        }

        public IResult Remove(Cafeteria cafeteria)
        {
            _cafeteriaDal.Delete(cafeteria);
            return new SuccessResult();
        }

        public IResult Update(Cafeteria cafeteria)
        {
            _cafeteriaDal.Update(cafeteria);
            return new SuccessResult();
        }
    }
}
