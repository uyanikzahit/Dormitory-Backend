using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IStudentDal : IEntityRepository<Student>
    {
        List<StudentDetailDto> GetStudentDetails(Expression<Func<StudentDetailDto, bool>> filter = null);
    }
}
