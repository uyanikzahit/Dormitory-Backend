using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
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
    public class EfRecordDal : EfEntityRepositoryBase<Record, DormitoryContext>, IRecordDal
    {
        public List<RecordDetailDto> GetRecordByUserAndActivity(int userId, int activityId)
        {
            using (DormitoryContext context = new DormitoryContext())
            {
                var result = from r in context.Records
                             join u in context.Users
                                on r.UserId equals u.Id
                             join a in context.Activities
                                on r.ActivityId equals a.ActivityId
                             where r.UserId == userId && r.ActivityId == activityId
                             select new RecordDetailDto()
                             {
                                 RecordId = r.Id,
                                 RecordName =r .RecordName,
                                 Date = r.Date,
                                 UserId = u.Id,
                                 Email = u.Email,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 ActivityId = a.ActivityId,
                                 ActivityName = a.ActivityName,
                             };
                return result.ToList();
            }
        }

        public List<RecordDetailDto> GetRecordDetails(Expression<Func<RecordDetailDto, bool>> filter = null)
        {
            using (DormitoryContext context = new DormitoryContext())
            {
                var result = from r in context.Records
                             join u in context.Users
                               on r.UserId equals u.Id
                             join a in context.Activities
                                on r.ActivityId equals a.ActivityId

                             select new RecordDetailDto
                             {
                                 UserId = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 ActivityId = a.ActivityId,
                                 ActivityName = a.ActivityName,
                                 Date = a.Date,
                                 RecordName = r.RecordName
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
                             

            }
        }
    }
}
