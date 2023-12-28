using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISuggestionService
    {
        IResult Add(Suggestion suggestion);
        IResult Update(Suggestion suggestion);
        IResult Delete(Suggestion suggestion);
        IDataResult<List<Suggestion>> GetAll();
        IDataResult<Suggestion> GetById(int suggestionId);
        IDataResult<List<SuggestionDetailDto>> GetSuggestionDetails();
        IDataResult<List<SuggestionDetailDto>> GetSuggestionDetailsId(int suggestionId);
        IDataResult<List<Suggestion>> GetSuggestionByUserId(int userId);
    }
}
