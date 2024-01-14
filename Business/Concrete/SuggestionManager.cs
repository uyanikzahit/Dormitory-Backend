using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SuggestionManager : ISuggestionService
    {
        ISuggestionDal _suggestionDal;
        IUserDal _userDal;

        public SuggestionManager(ISuggestionDal suggestionDal, IUserDal userDal)
        {
            _suggestionDal = suggestionDal;
            _userDal = userDal;
        }


        [CacheRemoveAspect("SuggestionService.Get")]
        public IResult Delete(Suggestion suggestion)
        {
            _suggestionDal.Delete(suggestion);
            return new SuccessResult(Messages.SuggestionDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Suggestion>> GetAll()
        {
            return new SuccessDataResult<List<Suggestion>>(_suggestionDal.GetAll(), Messages.SuggestionsListed);
        }

        [CacheAspect]
        public IDataResult<Suggestion> GetById(int suggestionId)
        {
            return new SuccessDataResult<Suggestion>(_suggestionDal.Get(s => s.Id == suggestionId));
        }

        [CacheAspect]
        public IDataResult<List<Suggestion>> GetSuggestionByUserId(int userId)
        {
            return new SuccessDataResult<List<Suggestion>>(_suggestionDal.GetAll(u => u.UserId == userId));

        }

        [CacheAspect]
        public IDataResult<List<SuggestionDetailDto>> GetSuggestionDetails()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<SuggestionDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<SuggestionDetailDto>>(_suggestionDal.GetSuggestionDetails(), Messages.SuggestionDetailsListed);
        }

        [CacheAspect]
        public IDataResult<List<SuggestionDetailDto>> GetSuggestionDetailsId(int suggestionId)
        {
            List<SuggestionDetailDto> suggestionDetails = _suggestionDal.GetSuggestionDetails(s => s.Id == suggestionId);
            if (suggestionDetails == null)
            {
                return new ErrorDataResult<List<SuggestionDetailDto>>("");
            }
            else
            {
                return new SuccessDataResult<List<SuggestionDetailDto>>(suggestionDetails, "");
            }
        }

        [ValidationAspect(typeof(SuggestionValidator))]
        public IResult Update(Suggestion suggestion)
        {
            var userExists = _userDal.Get(u => u.Id == suggestion.UserId);
            if (userExists == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            _suggestionDal.Update(suggestion);
            return new SuccessResult(Messages.SchoolUpdated);
        }


        [CacheRemoveAspect("SuggestionService.Get")]
        [ValidationAspect(typeof(SuggestionValidator))]
        public IResult Add(Suggestion suggestion)
        {
            //IResult result = BusinessRules.Run(ChechIfUserExists(suggestion.UserId));
            //if (result == null)
            //{
            //    return result;
            //}
            //return new SuccessResult();

            var userExists = _userDal.Get(u => u.Id == suggestion.UserId);
            if (userExists == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            _suggestionDal.Add(suggestion);
            return new SuccessResult(Messages.SuggestionAdded);
        }


        //Yapılacak öneride kullanıcı eklerken kullanıcının olduğunu kontrol eden business kuralı.
        private IResult ChechIfUserExists(int userId)
        {
            var userExists = _userDal.Get(u => u.Id == userId);
            if (userExists == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            return new SuccessResult();
        }
    }
}
