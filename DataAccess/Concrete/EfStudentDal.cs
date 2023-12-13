using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, DormitoryContext>, IStudentDal
    {
        public List<StudentDetailDto> GetStudentDetails(Expression<Func<StudentDetailDto, bool>> filter = null)
        {
            using (DormitoryContext context = new DormitoryContext())
            {
                var result = from s in context.Students
                             join u in context.Users
                                on s.StudentId equals u.Id
                             join ro in context.Rooms
                                 on s.RoomId equals ro.RoomId
                             join sch in context.Schools
                                 on s.ShcoolId equals sch.SchoolId

                             select new StudentDetailDto
                             {
                                 StudentId = u.Id,
                                 Email = u.Email,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RoomId = ro.RoomId,
                                 RoomNumber = ro.RoomNumber,
                                 FloorNumber = ro.FloorNumber,
                                 ShcoolId = sch.SchoolId,
                                 SchoolName = sch.SchoolName,
                                 SchoolSection = sch.SchoolSection,
                                 
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();


            }
        }
    }
}
