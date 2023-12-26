using Business.Abstract;
using Business.Constants;
using Business.FluentValidation;
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
        public IResult Add(Cafeteria cafeteria)
        {
            _cafeteriaDal.Add(cafeteria);
            return new SuccessResult(Messages.CafeteriaAdded);
        }

        public IDataResult<List<Cafeteria>> GetAll()
        {
            return new SuccessDataResult<List<Cafeteria>>(_cafeteriaDal.GetAll(), Messages.CafeteriasListed);
        }

        public IDataResult<Cafeteria> GetCafeteriaById(int cafeteriaId)
        {
            return new SuccessDataResult<Cafeteria>(_cafeteriaDal.Get(b => b.Id == cafeteriaId),Messages.CafeteriaListed);
        }

        public IResult Remove(Cafeteria cafeteria)
        {
            _cafeteriaDal.Delete(cafeteria);
            return new SuccessResult(Messages.CafeteriaDeleted);
        }

        [ValidationAspect(typeof(CafeteriaValidator))]
        public IResult Update(Cafeteria cafeteria)
        {
            _cafeteriaDal.Update(cafeteria);
            return new SuccessResult(Messages.CafeteriaUpdated);
        }
    }
}
