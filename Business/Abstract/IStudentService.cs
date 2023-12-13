using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        IDataResult<List<Student>> GetAll();
        IDataResult<Student> GetById(int studentId);
        IDataResult<List<StudentDetailDto>> GetStudentDetails();
        IDataResult<List<StudentDetailDto>> GetStudentDetailsId(int studentId);
        IResult Add(Student student);
        IResult Update(Student student);
        IResult Delete(Student student);
    }
}
