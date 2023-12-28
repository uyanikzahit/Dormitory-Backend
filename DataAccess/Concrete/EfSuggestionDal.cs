using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfSuggestionDal : EfEntityRepositoryBase<Suggestion, DormitoryContext>, ISuggestionDal
    {
        
        public List<SuggestionDetailDto> GetSuggestionDetails(Expression<Func<SuggestionDetailDto, bool>> filter = null)
        {
            using (DormitoryContext context = new DormitoryContext())
            {
                var result = from s in context.Suggestions
                             join u in context.Users
                               on s.UserId equals u.Id

                             select new SuggestionDetailDto
                             {
                                 UserId = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 Id = s.Id,

                                 

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}
