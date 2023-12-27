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
        public List<RecordDetailDto> GetSuggestionDetails()
        {

            using (DormitoryContext context = new DormitoryContext())
            {
                var result = from s in context.Suggestions
                             join u in context.Users
                               on s.UserId equals u.Id
                             

                             select new RecordDetailDto
                             {
                                 UserId = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 
                             };
                return result.ToList();

            }
        }
    }
}
