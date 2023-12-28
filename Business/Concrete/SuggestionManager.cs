using Business.Constants;
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

        public SuggestionManager(ISuggestionDal suggestionDal)
        {
            _suggestionDal = suggestionDal;
        }

        public IResult Add(Suggestion suggestion)
        {
            _suggestionDal.Add(suggestion);
            return new SuccessResult(Messages.SuggestionAdded);
        }

        public IResult Delete(Suggestion suggestion)
        {
            _suggestionDal.Delete(suggestion);
            return new SuccessResult(Messages.SuggestionDeleted);
        }

        public IDataResult<List<Suggestion>> GetAll()
        {
            return new SuccessDataResult<List<Suggestion>>(_suggestionDal.GetAll(), Messages.SuggestionsListed);
        }

        public IDataResult<Suggestion> GetById(int suggestionId)
        {
            return new SuccessDataResult<Suggestion>(_suggestionDal.Get(s => s.Id == suggestionId));
        }

        public IDataResult<List<Suggestion>> GetSuggestionByUserId(int userId)
        {
            return new SuccessDataResult<List<Suggestion>>(_suggestionDal.GetAll(u => u.UserId == userId));

        }

        public IDataResult<List<SuggestionDetailDto>> GetSuggestionDetails()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<SuggestionDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<SuggestionDetailDto>>(_suggestionDal.GetSuggestionDetails(), Messages.SuggestionDetailsListed);
        }
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

        public IResult Update(Suggestion suggestion)
        {
            _suggestionDal.Update(suggestion);
            return new SuccessResult(Messages.SchoolUpdated);
        }
    }
}
