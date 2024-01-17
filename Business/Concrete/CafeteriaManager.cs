using Business.Abstract;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
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

        [ValidationAspect(typeof(CafeteriaValidator))]
        [CacheRemoveAspect("CafeteriaService.Get")]
        public IResult Add(Cafeteria cafeteria)
        {
            _cafeteriaDal.Add(cafeteria);
            return new SuccessResult(Messages.CafeteriaAdded);
        }


        [CacheAspect]
        public IDataResult<List<Cafeteria>> GetAll()
        {
            return new SuccessDataResult<List<Cafeteria>>(_cafeteriaDal.GetAll(), Messages.CafeteriasListed);
        }

        [CacheAspect]
        public IDataResult<Cafeteria> GetCafeteriaByDate(DateTime dateTime)
        {
            return new SuccessDataResult<Cafeteria>(_cafeteriaDal.Get(c => c.Date == dateTime), Messages.CafeteriaListedByDate);
        }


        [CacheAspect]
        public IDataResult<Cafeteria> GetCafeteriaById(int cafeteriaId)
        {
            return new SuccessDataResult<Cafeteria>(_cafeteriaDal.Get(b => b.Id == cafeteriaId),Messages.CafeteriaListed);
        }


        [CacheRemoveAspect("CafeteriaService.Get")]
        public IResult Remove(Cafeteria cafeteria)
        {
            _cafeteriaDal.Delete(cafeteria);
            return new SuccessResult(Messages.CafeteriaDeleted);
        }

        [ValidationAspect(typeof(CafeteriaValidator))]
        [CacheRemoveAspect("CafeteriaService.Get")]
        public IResult Update(Cafeteria cafeteria)
        {
            _cafeteriaDal.Update(cafeteria);
            return new SuccessResult(Messages.CafeteriaUpdated);
        }
    }
}
