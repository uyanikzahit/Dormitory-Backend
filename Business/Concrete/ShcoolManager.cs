using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using DataAccess.Abstract;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ShcoolManager : IShcoolService
    {
        private IShcoolService _shcoolService;

        public ShcoolManager(IShcoolService shcoolService)
        {
            _shcoolService = shcoolService;
        }

        public IResult Add(Shcool shcool)
        {
            _shcoolService.Add(shcool);
            return new SuccessResult(Messages.ShcoolAdded);
        }

        public IDataResult<List<Shcool>> GetAll()
        {
            return new SuccessDataResult<List<Shcool>>(_shcoolService.GetAll(), Messages.ShcoolsListed);
            
        }

        public IDataResult<Shcool> GetShcoolById(int shcoolId)
        {
            return new SuccessDataResult<Shcool>(_shcoolService.Get(s => s.ShcoolId == shcoolId), Messages.ShcoolListed);

        }

        public IResult Remove(Shcool shcool)
        {
            _shcoolService.Remove(shcool);
            return new SuccessResult(Messages.ShcoolDeleted);
        }

        public IResult Update(Shcool shcool)
        {
            _shcoolService.Update(shcool);
            return new SuccessResult(Messages.ShcoolUpdated); ;
        }

       
    }
}
